/* 何问起 http://hovertree.com/hovertreescj/ */
using System;
using System.IO;

namespace HoverTree.HoverTreeFrame.HTIO
{
    public delegate string HoverTreeFileDeal(FileInfo info);
    /// <summary>
    /// 文件循环
    /// </summary>
    public class HoverTreeErgodic
    {
        int _filesCount = 0, _foldersCount = 0;
        string _hvtTips = "";
        HoverTreeFileDeal _hoverTreeFileDeal;


        /// <summary>
        /// 提示信息
        /// </summary>
        public string HvtTips
        {
            get
            {
                return _hvtTips;
            }
        }
        /// <summary>
        /// 文件总数
        /// </summary>
        public int FilesCount
        {
            get { return _filesCount; }
        }

        /// <summary>
        /// 子文件夹总数
        /// </summary>
        public int FoldersCount
        {
            get
            {
                return _foldersCount;
            }
        }

        public string FileBianli(DirectoryInfo dInfo, HoverTreeFileDeal mydelegate)
        {
            if (mydelegate == null)
            {
                return "处理方法不能为空";
            }
            _hoverTreeFileDeal = mydelegate;
            FolderLoop(dInfo);
            return HvtTips;
        }

        bool FolderLoop(DirectoryInfo dInfo)
        {

            if (dInfo == null)
            {
                return false;
            }
            FilesLoop(dInfo);

            DirectoryInfo[] h_directoryInfo = null;
            try
            {
                h_directoryInfo = dInfo.GetDirectories();
            }
            catch (Exception ex)
            {
                _hvtTips = ex.Message;
                return false;
            }
            if (h_directoryInfo == null)
                return false;

            if (h_directoryInfo.Length < 1)
            {
                return false;
            }

            foreach (DirectoryInfo info in h_directoryInfo)
            {
                _foldersCount = _foldersCount + 1;
                FolderLoop(info);
            }

            return true;
        }

        bool FilesLoop(DirectoryInfo dInfo)
        {
            if (dInfo == null)
                return false;
            FileInfo[] h_files;
            try
            {
                h_files = dInfo.GetFiles();
            }
            catch (UnauthorizedAccessException ex)
            {
                _hvtTips = ex.Message;
                return false;
            }

            if (h_files == null)
                return false;

            foreach (FileInfo fi in h_files)
            {
                _filesCount = _filesCount + 1;
                _hoverTreeFileDeal(fi);
            }

            return true;
        }
    }
}
