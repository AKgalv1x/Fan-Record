namespace FanRecord.Models
{
    public class Fanwork
    {
        public string Titulo { get; set; } = string.Empty;
        public string Desarrollador { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Imagen { get; set; } = "dotnet_bot.png"; // Imagen por defecto
        public string Reseña { get; set; } = string.Empty;

        // Los tags como una lista (Idioma, Medio, Status, etc.)
        public List<string> Tags { get; set; } = new();

        // Para el link original
        public string UrlOrigen { get; set; } = string.Empty;

        public bool EsFavorito { get; set; }
    }
}