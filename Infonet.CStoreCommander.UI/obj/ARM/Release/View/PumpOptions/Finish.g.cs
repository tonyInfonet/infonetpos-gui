﻿#pragma checksum "C:\Infonet_final\InfonetUI-UWP_Dev\Infonet.CStoreCommander.UI\View\PumpOptions\Finish.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "332C0E9C42908D1A80AC4D86E7B967AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonet.CStoreCommander.UI.View.PumpOptions
{
    partial class Finish : 
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
            public static void Set_MyToolkit_Controls_DataGrid_SelectedItem(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_MyToolkit_Controls_DataGrid_ItemsSource(global::MyToolkit.Controls.DataGrid obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
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

        private class Finish_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFinish_Bindings
        {
            private global::Infonet.CStoreCommander.UI.View.PumpOptions.Finish dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Infonet.CStoreCommander.UI.Controls.ViewHeading obj2;
            private global::MyToolkit.Controls.DataGrid obj3;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj4;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj5;
            private global::Infonet.CStoreCommander.ControlLib.GenericButton obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;

            private Finish_obj1_BindingsTracking bindingsTracking;

            public Finish_obj1_Bindings()
            {
                this.bindingsTracking = new Finish_obj1_BindingsTracking(this);
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
                        (this.obj3).RegisterPropertyChangedCallback(global::MyToolkit.Controls.DataGrid.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.FinishVM.SelectedUncompleteSaleModel = (global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel)this.LookupConverter("NothingConverter").ConvertBack((this.obj3).SelectedItem, typeof(global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel), null, null);
                                }
                            });
                        break;
                    case 4:
                        this.obj4 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 5:
                        this.obj5 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 6:
                        this.obj6 = (global::Infonet.CStoreCommander.ControlLib.GenericButton)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IFinish_Bindings

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

            // Finish_obj1_Bindings

            public void SetDataRoot(global::Infonet.CStoreCommander.UI.View.PumpOptions.Finish newDataRoot)
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
            private void Update_(global::Infonet.CStoreCommander.UI.View.PumpOptions.Finish obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FinishVM(obj.FinishVM, phase);
                    }
                }
            }
            private void Update_FinishVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FinishVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FinishVM(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FinishVM_BackCommand(obj.BackCommand, phase);
                        this.Update_FinishVM_SelectedUncompleteSaleModel(obj.SelectedUncompleteSaleModel, phase);
                        this.Update_FinishVM_UncompletePrepayModel(obj.UncompletePrepayModel, phase);
                        this.Update_FinishVM_CompleteChangeCommand(obj.CompleteChangeCommand, phase);
                        this.Update_FinishVM_CompleteOverPaymentCommand(obj.CompleteOverPaymentCommand, phase);
                        this.Update_FinishVM_DeleteCommand(obj.DeleteCommand, phase);
                    }
                }
            }
            private void Update_FinishVM_BackCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Infonet_CStoreCommander_UI_Controls_ViewHeading_BackCommand(this.obj2, obj, null);
                }
            }
            private void Update_FinishVM_SelectedUncompleteSaleModel(global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_SelectedItem(this.obj3, (global::System.Object)this.LookupConverter("NothingConverter").Convert(obj, typeof(global::System.Object), null, null), null);
                }
            }
            private void Update_FinishVM_UncompletePrepayModel(global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompletePrepayModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_FinishVM_UncompletePrepayModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_FinishVM_UncompletePrepayModel_UncompleteSale(obj.UncompleteSale, phase);
                        this.Update_FinishVM_UncompletePrepayModel_IsChangeEnabled(obj.IsChangeEnabled, phase);
                        this.Update_FinishVM_UncompletePrepayModel_IsOverPaymentEnabled(obj.IsOverPaymentEnabled, phase);
                        this.Update_FinishVM_UncompletePrepayModel_IsDeleteEnabled(obj.IsDeleteEnabled, phase);
                        this.Update_FinishVM_UncompletePrepayModel_IsDeleteVisible(obj.IsDeleteVisible, phase);
                        this.Update_FinishVM_UncompletePrepayModel_Caption(obj.Caption, phase);
                    }
                }
            }
            private void Update_FinishVM_UncompletePrepayModel_UncompleteSale(global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_MyToolkit_Controls_DataGrid_ItemsSource(this.obj3, obj, null);
                }
            }
            private void Update_FinishVM_CompleteChangeCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                }
            }
            private void Update_FinishVM_UncompletePrepayModel_IsChangeEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj4, obj);
                }
            }
            private void Update_FinishVM_CompleteOverPaymentCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                }
            }
            private void Update_FinishVM_UncompletePrepayModel_IsOverPaymentEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj5, obj);
                }
            }
            private void Update_FinishVM_DeleteCommand(global::GalaSoft.MvvmLight.Command.RelayCommand obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_FinishVM_UncompletePrepayModel_IsDeleteEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj6, obj);
                }
            }
            private void Update_FinishVM_UncompletePrepayModel_IsDeleteVisible(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_FinishVM_UncompletePrepayModel_Caption(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                }
            }

            private class Finish_obj1_BindingsTracking
            {
                global::System.WeakReference<Finish_obj1_Bindings> WeakRefToBindingObj; 

                public Finish_obj1_BindingsTracking(Finish_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Finish_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_FinishVM(null);
                    UpdateChildListeners_FinishVM_UncompletePrepayModel(null);
                }

                public void PropertyChanged_FinishVM(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Finish_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FinishVM obj = sender as global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FinishVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_FinishVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    bindings.Update_FinishVM_SelectedUncompleteSaleModel(obj.SelectedUncompleteSaleModel, DATA_CHANGED);
                                    bindings.Update_FinishVM_UncompletePrepayModel(obj.UncompletePrepayModel, DATA_CHANGED);
                                    bindings.Update_FinishVM_CompleteChangeCommand(obj.CompleteChangeCommand, DATA_CHANGED);
                                    bindings.Update_FinishVM_CompleteOverPaymentCommand(obj.CompleteOverPaymentCommand, DATA_CHANGED);
                                    bindings.Update_FinishVM_DeleteCommand(obj.DeleteCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "BackCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_BackCommand(obj.BackCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedUncompleteSaleModel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_SelectedUncompleteSaleModel(obj.SelectedUncompleteSaleModel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "UncompletePrepayModel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel(obj.UncompletePrepayModel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CompleteChangeCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_CompleteChangeCommand(obj.CompleteChangeCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "CompleteOverPaymentCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_CompleteOverPaymentCommand(obj.CompleteOverPaymentCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "DeleteCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_DeleteCommand(obj.DeleteCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FinishVM cache_FinishVM = null;
                public void UpdateChildListeners_FinishVM(global::Infonet.CStoreCommander.UI.ViewModel.PumpOptions.FinishVM obj)
                {
                    if (obj != cache_FinishVM)
                    {
                        if (cache_FinishVM != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_FinishVM).PropertyChanged -= PropertyChanged_FinishVM;
                            cache_FinishVM = null;
                        }
                        if (obj != null)
                        {
                            cache_FinishVM = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_FinishVM;
                        }
                    }
                }
                public void PropertyChanged_FinishVM_SelectedUncompleteSaleModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Finish_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel obj = sender as global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel;
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
                public void PropertyChanged_FinishVM_UncompletePrepayModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Finish_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompletePrepayModel obj = sender as global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompletePrepayModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_FinishVM_UncompletePrepayModel_UncompleteSale(obj.UncompleteSale, DATA_CHANGED);
                                    bindings.Update_FinishVM_UncompletePrepayModel_IsChangeEnabled(obj.IsChangeEnabled, DATA_CHANGED);
                                    bindings.Update_FinishVM_UncompletePrepayModel_IsOverPaymentEnabled(obj.IsOverPaymentEnabled, DATA_CHANGED);
                                    bindings.Update_FinishVM_UncompletePrepayModel_IsDeleteEnabled(obj.IsDeleteEnabled, DATA_CHANGED);
                                    bindings.Update_FinishVM_UncompletePrepayModel_IsDeleteVisible(obj.IsDeleteVisible, DATA_CHANGED);
                                    bindings.Update_FinishVM_UncompletePrepayModel_Caption(obj.Caption, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "UncompleteSale":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel_UncompleteSale(obj.UncompleteSale, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsChangeEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel_IsChangeEnabled(obj.IsChangeEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsOverPaymentEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel_IsOverPaymentEnabled(obj.IsOverPaymentEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsDeleteEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel_IsDeleteEnabled(obj.IsDeleteEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsDeleteVisible":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel_IsDeleteVisible(obj.IsDeleteVisible, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Caption":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_FinishVM_UncompletePrepayModel_Caption(obj.Caption, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompletePrepayModel cache_FinishVM_UncompletePrepayModel = null;
                public void UpdateChildListeners_FinishVM_UncompletePrepayModel(global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompletePrepayModel obj)
                {
                    if (obj != cache_FinishVM_UncompletePrepayModel)
                    {
                        if (cache_FinishVM_UncompletePrepayModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_FinishVM_UncompletePrepayModel).PropertyChanged -= PropertyChanged_FinishVM_UncompletePrepayModel;
                            cache_FinishVM_UncompletePrepayModel = null;
                        }
                        if (obj != null)
                        {
                            cache_FinishVM_UncompletePrepayModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_FinishVM_UncompletePrepayModel;
                        }
                    }
                }
                public void PropertyChanged_FinishVM_UncompletePrepayModel_UncompleteSale(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Finish_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel>;
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
                public void CollectionChanged_FinishVM_UncompletePrepayModel_UncompleteSale(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    Finish_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Infonet.CStoreCommander.UI.Model.FuelPump.UncompleteSaleModel>;
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
                    Finish_obj1_Bindings bindings = new Finish_obj1_Bindings();
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

