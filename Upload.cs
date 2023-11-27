namespace fileuploadapi
{
    public class Upload
    {
        public IFormFile htmlfile {  get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;

    }
}
