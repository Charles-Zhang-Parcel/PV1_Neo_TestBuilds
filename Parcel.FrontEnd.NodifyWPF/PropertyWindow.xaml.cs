﻿using System.Windows;
using Parcel.Shared.Framework.ViewModels.BaseNodes;

namespace Parcel.FrontEnd.NodifyWPF
{
    public partial class PropertyWindow : BaseWindow
    {
        public PropertyWindow(Window owner, ProcessorNode processor)
        {
            Processor = processor;
            Owner = owner;
            InitializeComponent();
        }

        public ProcessorNode Processor { get; set; }
    }
}