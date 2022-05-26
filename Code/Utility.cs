using System.IO;
using System.Reflection;

namespace ForgetMeNot
{
    static class Utility
    {
        /// <summary>
        /// Returns the embedded resource with the given filepath if found, null otherwise
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns>Stream of the embedded resource</returns>
        public static Stream GetStreamFromFile(string filepath)
        {
            filepath = filepath.Replace('/', '.');
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream($"ForgetMeNot.{filepath}");
        }
    }
}