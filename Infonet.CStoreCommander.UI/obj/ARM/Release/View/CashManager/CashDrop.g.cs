﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\CashManager\CashDrop.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "260B5040DAAB8F205FA0BF4EF4E5E108"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.CashManager
{
    partial class CashDrop : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.BackCommand = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemsSource(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class CashDrop_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICashDrop_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.CashManager.CashDrop dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj2;
            private global::MyToolkit.Controls.DataGrid obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            private CashDrop_obj1_BindingsTracking bindingsTracking;

            public CashDrop_obj1_Bindings()
            {
                this.bindingsTracking = new CashDrop_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Infonet.CStoreCommander.UI.Controls.ViewHeading)target;
                        break;
                    case 3:
                        this.obj3 = (global::MyToolkit.Controls.DataGrid)target;
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // ICashDrop_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // CashDrop_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.CashManager.CashDrop newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Infonet.CStoreCommander.UI.View.CashManager.CashDrop obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CashDropVM(obj.CashDropVM, phase);
                    }
                }
            }
            private void Update_CashDropVM(global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_CashDropVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CashDropVM_CancelTenderCommand(obj.CancelTenderCommand, phase);
                        this.Update_CashDropVM_SelectedTenderList(obj.SelectedTenderList, phase);
                        this.Update_CashDropVM_IsSelectedTenderEmpty(obj.IsSelectedTenderEmpty, phase);
                        this.Update_CashDropVM_CompleteTenderCommand(obj.CompleteTenderCommand, phase);
                        this.Update_CashDropVM_TenderTotalAmount(obj.TenderTotalAmount, phase);
                    }
                }
            }
            private void Update_CashDropVM_CancelTenderCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(this.obj2, obj, null);
                }
            }
            private void Update_CashDropVM_SelectedTenderList(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj3, obj, null);
                }
            }
            private void Update_CashDropVM_IsSelectedTenderEmpty(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_CashDropVM_CompleteTenderCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_CashDropVM_TenderTotalAmount(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, (global::System.String)this.LookupConverter("CurrencyConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }

            private class CashDrop_obj1_BindingsTracking
            {
                global::System.WeakReference<CashDrop_obj1_Bindings> WeakRefToBindingObj; 

                public CashDrop_obj1_BindingsTracking(CashDrop_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<CashDrop_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_CashDropVM(null);
                }

                public void PropertyChanged_CashDropVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CashDrop_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_CashDropVM_CancelTenderCommand(obj.CancelTenderCommand, DATA_CHANGED);
                                    bindings.Update_CashDropVM_SelectedTenderList(obj.SelectedTenderList, DATA_CHANGED);
                                    bindings.Update_CashDropVM_IsSelectedTenderEmpty(obj.IsSelectedTenderEmpty, DATA_CHANGED);
                                    bindings.Update_CashDropVM_CompleteTenderCommand(obj.CompleteTenderCommand, DATA_CHANGED);
                                    bindings.Update_CashDropVM_TenderTotalAmount(obj.TenderTotalAmount, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CancelTenderCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CashDropVM_CancelTenderCommand(obj.CancelTenderCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedTenderList":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CashDropVM_SelectedTenderList(obj.SelectedTenderList, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsSelectedTenderEmpty":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CashDropVM_IsSelectedTenderEmpty(obj.IsSelectedTenderEmpty, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CompleteTenderCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CashDropVM_CompleteTenderCommand(obj.CompleteTenderCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "TenderTotalAmount":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CashDropVM_TenderTotalAmount(obj.TenderTotalAmount, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM cache_CashDropVM = null;
                public void UpdateChildListeners_CashDropVM(global::Infonet.CStoreCommander.UI.ViewModel.CashManager.CashDropVM obj)
                {
                    if (obj != cache_CashDropVM)
                    {
                        if (cache_CashDropVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_CashDropVM).PropertyChanged -= PropertyChanged_CashDropVM;
                            cache_CashDropVM = null;
                        }
                        if (obj != null)
                        {
                            cache_CashDropVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_CashDropVM;
                        }
                    }
                }
                public void PropertyChanged_CashDropVM_SelectedTenderList(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CashDrop_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_CashDropVM_SelectedTenderList(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    CashDrop_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.Cash.TenderModel>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3:
                {
                    this.DataGrid = (global::MyToolkit.Controls.DataGrid)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CashDrop_obj1_Bindings bindings = new CashDrop_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
