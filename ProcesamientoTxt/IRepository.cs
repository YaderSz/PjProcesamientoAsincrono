using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoTxt
{
    public interface IRepository
    {
          Task<string> ReadFileAsync(string filePath);
          Task<string> ProcessTextAsync(string text);
          Task WriteFileAsync(string filePath, string content);



    }
}
