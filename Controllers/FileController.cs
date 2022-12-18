using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatybaServer.Shared;
using System.Net;

namespace StatybaServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FileController : ControllerBase
	{
		private readonly IWebHostEnvironment _env;
		public FileController(IWebHostEnvironment env)
		{
			_env = env;
		}

		[HttpPost]
		public async Task<ActionResult<List<UploadResult>>> UploadFile(List<IFormFile> files)
		{
			List<UploadResult> uploadResults = new List<UploadResult>();
			foreach(var file in files)
			{
				var uploadResult = new UploadResult();
				string trustedFileNameForFileStorage;
				var untrustedFileName = file.FileName;
				uploadResult.FileName = untrustedFileName;
				var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);
				

				trustedFileNameForFileStorage = Path.GetRandomFileName();
				trustedFileNameForFileStorage += ".jpg";
				
				var path = Path.Combine(_env.ContentRootPath, "wwwroot\\uploads", trustedFileNameForFileStorage);

				await using FileStream fs = new(path, FileMode.Create);
				await file.CopyToAsync(fs);

				uploadResult.StoredFileName = trustedFileNameForFileStorage;
				uploadResult.DisplayFileName = trustedFileNameForDisplay;
				uploadResults.Add(uploadResult);

			}

			return Ok(uploadResults);
		}
	}
}
