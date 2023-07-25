using Locnes.Dialogues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Locnes.ToolsService
{
    public static class Actions
    {
        public static void ExitApp() {
            //var _f = new ExitWithoutSaving(); _f.Owner = Editeur.ActiveForm; _f.ShowDialog();
            Application.Exit(); }
        public static void MinimiseApp() { Editeur.instance.WindowState = FormWindowState.Minimized; }

        public static void OpenFolder(string path = null) {
            string _path = null;
            if(path != null ) { _path = path; }
            else {
                var _dial = new FolderBrowserDialog();
                if(_dial.ShowDialog() == DialogResult.OK) {
                    _path = Path.GetFullPath(_dial.SelectedPath); }
                else {
                    return; } }
            var _tree = new TreeView(); 
            var _rootname = _path.Split('\\').Last();
            var _root = _tree.Nodes.Add(_rootname);
            _root.ImageKey = "folder-16.png";
            _root = SolveTreeforPath(_path, _root);
            Editeur.instance.RequestNewTree(_tree);
            _tree.Dispose();
            Editeur.instance.OpenFolder = _path; }

        public static void OpenFiles(string[] paths = null) {
            string[] _paths = null;
            if(paths == null) {
                var _dial              =  new OpenFileDialog();
                    _dial.Filter       =  "All Files (*.*)|*.*";
                    _dial.FilterIndex  =  1;
                    _dial.Multiselect  =  true;
                if (_dial.ShowDialog() == DialogResult.OK) {
                    _paths = _dial.FileNames; } }
            else {
                _paths = paths; }

            if(_paths == null) { return; }

            foreach (string _file in _paths) {
                if(Path.GetExtension(_file) == "") { return; }
                Editeur.instance.OpenPaths.Add(Path.GetFullPath(_file));
                using (StreamReader _reader = new StreamReader(_file)) {
                    Editeur.instance.PathFinals.Add(_reader.ReadToEnd());
                    _reader.Close();
                    _reader.Dispose(); } }
            Editeur.instance.UpdateOpenFiles();
            Editeur.instance.SelectLastTab(); }

        public static void SaveStream(string content, string path = null) {
            string _path = null;
            if(path == null || path.StartsWith("unsaved_")) {
                var _dial = new SaveFileDialog();
                _dial.Filter = "Plain Text (*.txt)|*.txt";
                if (_dial.ShowDialog() == DialogResult.OK) {
                    _path = Path.GetFullPath(_dial.FileName); } }
            else {
                _path = path; }

            if(_path == null) { return; }

            using (StreamWriter _writer = new StreamWriter(_path)) {
                _writer.Write(content);
                _writer.Close();
                _writer.Dispose(); }
            if (Editeur.instance.OpenFolder != null) { OpenFolder(Editeur.instance.OpenFolder); } }






        // Functions Zone
        private static TreeNode SolveTreeforPath(string path, TreeNode original = null)
        {
            TreeNode _tree = new TreeNode();
            if(original != null) { _tree = original; }

            string[] _alldirs = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
            foreach (string _dir in _alldirs) {
                
                string _name = Path.GetFileName(_dir);
                TreeNode _node = new TreeNode(_name);
                _node.Name = Path.GetRelativePath(path, _dir);
                string _extension = Path.GetExtension(_dir);
                
                switch(_extension)
                {
                    case "": _node.ImageKey = "folder-16.png"; break;
                    case ".txt": _node.ImageKey = "textfile-16.png"; break;
                    case ".py": _node.ImageKey = "python-16.png"; break;
                }

                List<string> _hier = _dir.Split('\\').ToList();
                _hier.RemoveAt(_hier.Count - 1);
                string _updir = string.Join('\\', _hier);
                string _parentrel = Path.GetRelativePath(path, _updir);
                TreeNode[] _parent = _tree.Nodes.Find(_parentrel, true);
                
                if (_parent.Length != 0) { _parent.First().Nodes.Add(_node); }
                else                     { _tree.Nodes.Add(_node); }
            }

            return _tree;
        }
    }
}
