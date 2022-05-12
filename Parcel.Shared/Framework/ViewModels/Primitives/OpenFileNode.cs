﻿using System.IO;
using System.Windows;
using Parcel.Shared.Framework.ViewModels.BaseNodes;

namespace Parcel.Shared.Framework.ViewModels.Primitives
{
    public class OpenFileNode: StringNode
    {
        #region View Components
        public string Path
        {
            get => _value;
            set => SetField(ref _value, File.Exists(value) ? value : null);
        }
        #endregion
        
        #region Node Interface
        public readonly OutputConnector FilePathOutput = new OutputConnector(typeof(string))
        {
            Title = "File"
        }; 
        public OpenFileNode()
        {
            Title = NodeTypeName = "File";
            ValueOutput.IsHidden = true;
            Output.Add(FilePathOutput);
        }
        #endregion

        #region Interface
        public override OutputConnector MainOutput => FilePathOutput;
        public override NodeExecutionResult Execute()
        {
            ProcessorCache[FilePathOutput] = new ConnectorCacheDescriptor(Path);
            
            return base.Execute();
        }
        #endregion
    }
}