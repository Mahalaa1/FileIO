/**       
 *--------------------------------------------------------------------
 * 	   File name: FileRoot.cs
 * 	Project name: FileIO
 *--------------------------------------------------------------------
 * Author’s name and email:	Austin Mahala mahalaa1@etsu.edu				
 *          Course-Section: CSCI-2910-970
 *           Creation Date:	6-5-2023 	
 * -------------------------------------------------------------------
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class FileRoot
    {
        public static string fileRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}
