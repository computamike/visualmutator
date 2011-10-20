﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualMutator.Views
{
    using CommonUtilityInfrastructure.WpfUtils;

    /// <summary>
    /// Interaction logic for MutantDetailsView.xaml
    /// </summary>
    public partial class MutantDetailsView : UserControl, IMutantDetailsView
    {
        public MutantDetailsView()
        {
            InitializeComponent();
        }
    }

    public interface IMutantDetailsView : IView
    {
    }
}
