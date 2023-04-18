using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storm_winform
{
    public class Services
    {
  
        public static List<string> ScanDirectoriesForPattern(string[] paths)
        {
            var result = new List<string>();

            for (int i = 0; i < paths.Length; i++)
            {
                var path = paths[i];
                var parent = Path.GetDirectoryName(path);
                var name = Path.GetFileName(path);

                if (Directory.Exists(path))
                    result.Add(path);        
            }
            return result;
        }
    }
}
