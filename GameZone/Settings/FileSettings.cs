namespace GameZone.Settings
{
    public class FileSettings 
    {
        public const string ImagesPath = "/assets/images/games";
        public const string AllowedExtensions = ".jpg, .jpeg, .png";
        public const int MaxeFileSizeInMB = 1;
        public const int MaxeFileSizeInBytes = MaxeFileSizeInMB * 1024 * 1024;     
    }
}
