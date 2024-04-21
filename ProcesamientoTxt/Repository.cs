using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoTxt
{
    public class Repository : IRepository
    {
        public async Task<string> ReadFileAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public async Task<string> ProcessTextAsync(string text)
        {
            return text.ToUpper();
        }


        

        public async Task WriteFileAsync(string filePath, string content)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                await writer.WriteAsync(content);
            }
        }
    }
}
