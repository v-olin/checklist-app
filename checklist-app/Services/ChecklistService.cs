using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using checklist_app.Models;
using checklist_app.Pages;

namespace checklist_app.Services
{
    public class ChecklistService
    {
        public static async Task<Checklist?> ParseFileToChecklist(string filepath)
        {
            if (filepath == null || filepath == String.Empty)
            {
                var popup = new Popup("Filepath cannot be empty");
                return null;
            }
            else if (!File.Exists(filepath))
            {
                var popup = new Popup("File does not exist");
                popup
                return null;
            }

            using FileStream openStream = File.OpenRead(filepath);
            return await JsonSerializer.DeserializeAsync<Checklist>(openStream);
        }
    }
}
