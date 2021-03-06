using System.IO;
using Cake.Core.IO;

namespace Cake.Gulp
{
    /// <summary>
    /// gulp local runner settings
    /// </summary>
    public class GulpLocalRunnerSettings : GulpRunnerSettings
    {
        internal GulpLocalRunnerSettings(IFileSystem fileSystem) : base(fileSystem)
        {
        }

        /// <summary>
        /// Path to node modules
        /// </summary>
        public FilePath PathToGulpJs { get; private set; } = "./node_modules/gulp/bin/gulp.js";

        /// <summary>
        /// Overrides the default path to gulp javascript
        /// </summary>
        /// <param name="gulpJs">path to gulp if different from './node_modules/gulp/bin/gulp.js'</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public GulpLocalRunnerSettings SetPathToGulpJs(FilePath gulpJs)
        {
            if(!FileSystem.Exist(gulpJs)) throw new FileNotFoundException("gulp not found", gulpJs.FullPath);
            PathToGulpJs = gulpJs;
            return this;
        }
    }
}