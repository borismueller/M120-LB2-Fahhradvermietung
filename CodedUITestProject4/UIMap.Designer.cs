﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Dieser Code wurde vom Coded UI-Test-Generator generiert.
//      Version: 14.0.0.0
//
//      In dieser Datei sind spezialisierte Klassen definiert, die in einem
//      Coded UI-Test verwendet werden.
//      In dieser Datei können die erforderlichen Anpassungen vorgenommen werden.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject4
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Positivtest1 - Verwenden Sie "Positivtest1Params", um Parameter an diese Methode zu übergeben.
        /// </summary>
        public void Positivtest1()
        {
            #region Variable Declarations
            WinEdit uINameEdit = this.UIDebugWindow.UIItemWindow.UIM120LB2FS17ListItem.UINameEdit;
            WpfListItem uISystemDynamicExpandoListItem = this.UIMainWindowWindow.UILb_vermietungList.UISystemDynamicExpandoListItem;
            WpfButton uINeuButton = this.UIMainWindowWindow.UIItemCustom.UINeuButton;
            WpfButton uIItemButton = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem0Row.UIElement0AnzeigeindexCell.UIItemButton;
            WpfText uIAntenerText = this.UIMainWindowWindow.UIUc_selectKundenCustom.UIDg_listeTable.UIItem1Row.UIAntenerCell.UIAntenerText;
            WpfButton uISpeichernButton = this.UIMainWindowWindow.UIUc_selectKundenCustom.UISpeichernButton;
            WpfButton uIItemButton1 = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem0Row.UIElement0AnzeigeindexCell1.UIItemButton;
            WpfText uIScottText = this.UIMainWindowWindow.UIUc_selectFahrradCustom.UIDg_listeTable.UIItem1Row.UIScottCell.UIScottText;
            WpfButton uISpeichernButton1 = this.UIMainWindowWindow.UIUc_selectFahrradCustom.UISpeichernButton;
            WpfCell uIItem110001120000AMCell = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem0Row.UIItem110001120000AMCell;
            WpfEdit uIItemEdit = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem0Row.UIItem110001120000AMCell.UIItemEdit;
            WpfCell uIItem110001120000AMCell1 = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem0Row.UIItem110001120000AMCell1;
            WpfEdit uIItemEdit1 = this.UIMainWindowWindow.UIItemCustom.UIDg_vermietungTable.UIItem0Row.UIItem110001120000AMCell1.UIItemEdit;
            WpfButton uISpeichernButton2 = this.UIMainWindowWindow.UIItemCustom.UISpeichernButton;
            WpfButton uIHauptmenuButton = this.UIMainWindowWindow.UIItemCustom.UIHauptmenuButton;
            WinButton uISchließenButton = this.UIMainWindowWindow1.UISchließenButton;
            #endregion

            // Doppelklicken "Name" Textfeld
            Mouse.DoubleClick(uINameEdit, new Point(123, 1));

            // Klicken "System.Dynamic.ExpandoObject" Listenelement
            Mouse.Click(uISystemDynamicExpandoListItem, new Point(130, 11));

            // Klicken "Neu" Schaltfläche
            Mouse.Click(uINeuButton, new Point(137, 10));

            // Klicken Schaltfläche
            Mouse.Click(uIItemButton, new Point(27, 12));

            // Klicken "Antener" Bezeichnung
            Mouse.Click(uIAntenerText, new Point(25, 8));

            // Klicken "Speichern" Schaltfläche
            Mouse.Click(uISpeichernButton, new Point(98, 12));

            // Klicken Schaltfläche
            Mouse.Click(uIItemButton1, new Point(23, 5));

            // Klicken "Scott" Bezeichnung
            Mouse.Click(uIScottText, new Point(44, 10));

            // Klicken "Speichern" Schaltfläche
            Mouse.Click(uISpeichernButton1, new Point(144, 22));

            // "5/6/2017 8:00:00 AM" in "1/1/0001 12:00:00 AM" Zelle eingeben
            uIItem110001120000AMCell.Value = this.Positivtest1Params.UIItem110001120000AMCellValue;

            // '{Tab}' in Textfeld eingeben
            Keyboard.SendKeys(uIItemEdit, this.Positivtest1Params.UIItemEditSendKeys, ModifierKeys.None);

            // "5/6/2017 4:00:00 PM" in "1/1/0001 12:00:00 AM" Zelle eingeben
            uIItem110001120000AMCell1.Value = this.Positivtest1Params.UIItem110001120000AMCell1Value;

            // '{Enter}' in Textfeld eingeben
            Keyboard.SendKeys(uIItemEdit1, this.Positivtest1Params.UIItemEditSendKeys1, ModifierKeys.None);

            // Klicken "Speichern" Schaltfläche
            Mouse.Click(uISpeichernButton2, new Point(272, 15));

            // Klicken "Hauptmenu" Schaltfläche
            Mouse.Click(uIHauptmenuButton, new Point(304, 10));

            // Klicken "Schließen" Schaltfläche
            Mouse.Click(uISchließenButton, new Point(22, 24));
        }
        
        #region Properties
        public virtual Positivtest1Params Positivtest1Params
        {
            get
            {
                if ((this.mPositivtest1Params == null))
                {
                    this.mPositivtest1Params = new Positivtest1Params();
                }
                return this.mPositivtest1Params;
            }
        }
        
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if ((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIMainWindowWindow1 UIMainWindowWindow1
        {
            get
            {
                if ((this.mUIMainWindowWindow1 == null))
                {
                    this.mUIMainWindowWindow1 = new UIMainWindowWindow1();
                }
                return this.mUIMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private Positivtest1Params mPositivtest1Params;
        
        private UIDebugWindow mUIDebugWindow;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIMainWindowWindow1 mUIMainWindowWindow1;
        #endregion
    }
    
    /// <summary>
    /// An "Positivtest1" zu übergebende Parameter
    /// </summary>
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class Positivtest1Params
    {
        
        #region Fields
        /// <summary>
        /// "5/6/2017 8:00:00 AM" in "1/1/0001 12:00:00 AM" Zelle eingeben
        /// </summary>
        public string UIItem110001120000AMCellValue = "5/6/2017 8:00:00 AM";
        
        /// <summary>
        /// '{Tab}' in Textfeld eingeben
        /// </summary>
        public string UIItemEditSendKeys = "{Tab}";
        
        /// <summary>
        /// "5/6/2017 4:00:00 PM" in "1/1/0001 12:00:00 AM" Zelle eingeben
        /// </summary>
        public string UIItem110001120000AMCell1Value = "5/6/2017 4:00:00 PM";
        
        /// <summary>
        /// '{Enter}' in Textfeld eingeben
        /// </summary>
        public string UIItemEditSendKeys1 = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIDebugWindow : WinWindow
    {
        
        public UIDebugWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Debug";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Elementansicht";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIM120LB2FS17ListItem UIM120LB2FS17ListItem
        {
            get
            {
                if ((this.mUIM120LB2FS17ListItem == null))
                {
                    this.mUIM120LB2FS17ListItem = new UIM120LB2FS17ListItem(this);
                }
                return this.mUIM120LB2FS17ListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIM120LB2FS17ListItem mUIM120LB2FS17ListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIM120LB2FS17ListItem : WinListItem
    {
        
        public UIM120LB2FS17ListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinListItem.PropertyNames.Name] = "M120-LB2-FS17";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Suchkriterien
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UILb_vermietungList UILb_vermietungList
        {
            get
            {
                if ((this.mUILb_vermietungList == null))
                {
                    this.mUILb_vermietungList = new UILb_vermietungList(this);
                }
                return this.mUILb_vermietungList;
            }
        }
        
        public UIItemCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new UIItemCustom(this);
                }
                return this.mUIItemCustom;
            }
        }
        
        public UIUc_selectKundenCustom UIUc_selectKundenCustom
        {
            get
            {
                if ((this.mUIUc_selectKundenCustom == null))
                {
                    this.mUIUc_selectKundenCustom = new UIUc_selectKundenCustom(this);
                }
                return this.mUIUc_selectKundenCustom;
            }
        }
        
        public UIUc_selectFahrradCustom UIUc_selectFahrradCustom
        {
            get
            {
                if ((this.mUIUc_selectFahrradCustom == null))
                {
                    this.mUIUc_selectFahrradCustom = new UIUc_selectFahrradCustom(this);
                }
                return this.mUIUc_selectFahrradCustom;
            }
        }
        #endregion
        
        #region Fields
        private UILb_vermietungList mUILb_vermietungList;
        
        private UIItemCustom mUIItemCustom;
        
        private UIUc_selectKundenCustom mUIUc_selectKundenCustom;
        
        private UIUc_selectFahrradCustom mUIUc_selectFahrradCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UILb_vermietungList : WpfList
    {
        
        public UILb_vermietungList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "lb_vermietung";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfListItem UISystemDynamicExpandoListItem
        {
            get
            {
                if ((this.mUISystemDynamicExpandoListItem == null))
                {
                    this.mUISystemDynamicExpandoListItem = new WpfListItem(this);
                    #region Suchkriterien
                    this.mUISystemDynamicExpandoListItem.SearchProperties[WpfListItem.PropertyNames.Name] = "System.Dynamic.ExpandoObject";
                    this.mUISystemDynamicExpandoListItem.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISystemDynamicExpandoListItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfListItem mUISystemDynamicExpandoListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItemCustom : WpfCustom
    {
        
        public UIItemCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.VermietungEinzelansicht";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfButton UINeuButton
        {
            get
            {
                if ((this.mUINeuButton == null))
                {
                    this.mUINeuButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUINeuButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_neu";
                    this.mUINeuButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUINeuButton;
            }
        }
        
        public UIDg_vermietungTable UIDg_vermietungTable
        {
            get
            {
                if ((this.mUIDg_vermietungTable == null))
                {
                    this.mUIDg_vermietungTable = new UIDg_vermietungTable(this);
                }
                return this.mUIDg_vermietungTable;
            }
        }
        
        public WpfButton UISpeichernButton
        {
            get
            {
                if ((this.mUISpeichernButton == null))
                {
                    this.mUISpeichernButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUISpeichernButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_save";
                    this.mUISpeichernButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISpeichernButton;
            }
        }
        
        public WpfButton UIHauptmenuButton
        {
            get
            {
                if ((this.mUIHauptmenuButton == null))
                {
                    this.mUIHauptmenuButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUIHauptmenuButton.SearchProperties[WpfButton.PropertyNames.Name] = "Hauptmenu";
                    this.mUIHauptmenuButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIHauptmenuButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUINeuButton;
        
        private UIDg_vermietungTable mUIDg_vermietungTable;
        
        private WpfButton mUISpeichernButton;
        
        private WpfButton mUIHauptmenuButton;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIDg_vermietungTable : WpfTable
    {
        
        public UIDg_vermietungTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfTable.PropertyNames.AutomationId] = "dg_vermietung";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIItem0Row UIItem0Row
        {
            get
            {
                if ((this.mUIItem0Row == null))
                {
                    this.mUIItem0Row = new UIItem0Row(this);
                }
                return this.mUIItem0Row;
            }
        }
        #endregion
        
        #region Fields
        private UIItem0Row mUIItem0Row;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem0Row : WpfRow
    {
        
        public UIItem0Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfRow.PropertyNames.Name] = "0";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIElement0AnzeigeindexCell UIElement0AnzeigeindexCell
        {
            get
            {
                if ((this.mUIElement0AnzeigeindexCell == null))
                {
                    this.mUIElement0AnzeigeindexCell = new UIElement0AnzeigeindexCell(this);
                }
                return this.mUIElement0AnzeigeindexCell;
            }
        }
        
        public UIElement0AnzeigeindexCell1 UIElement0AnzeigeindexCell1
        {
            get
            {
                if ((this.mUIElement0AnzeigeindexCell1 == null))
                {
                    this.mUIElement0AnzeigeindexCell1 = new UIElement0AnzeigeindexCell1(this);
                }
                return this.mUIElement0AnzeigeindexCell1;
            }
        }
        
        public UIItem110001120000AMCell UIItem110001120000AMCell
        {
            get
            {
                if ((this.mUIItem110001120000AMCell == null))
                {
                    this.mUIItem110001120000AMCell = new UIItem110001120000AMCell(this);
                }
                return this.mUIItem110001120000AMCell;
            }
        }
        
        public UIItem110001120000AMCell1 UIItem110001120000AMCell1
        {
            get
            {
                if ((this.mUIItem110001120000AMCell1 == null))
                {
                    this.mUIItem110001120000AMCell1 = new UIItem110001120000AMCell1(this);
                }
                return this.mUIItem110001120000AMCell1;
            }
        }
        #endregion
        
        #region Fields
        private UIElement0AnzeigeindexCell mUIElement0AnzeigeindexCell;
        
        private UIElement0AnzeigeindexCell1 mUIElement0AnzeigeindexCell1;
        
        private UIItem110001120000AMCell mUIItem110001120000AMCell;
        
        private UIItem110001120000AMCell1 mUIItem110001120000AMCell1;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIElement0AnzeigeindexCell : WpfCell
    {
        
        public UIElement0AnzeigeindexCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Kunde";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUIItemButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIItemButton;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIElement0AnzeigeindexCell1 : WpfCell
    {
        
        public UIElement0AnzeigeindexCell1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Fahrrad";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUIItemButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIItemButton;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem110001120000AMCell : WpfCell
    {
        
        public UIItem110001120000AMCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Start";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WpfEdit(this);
                    #region Suchkriterien
                    this.mUIItemEdit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem110001120000AMCell1 : WpfCell
    {
        
        public UIItem110001120000AMCell1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Ende";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WpfEdit(this);
                    #region Suchkriterien
                    this.mUIItemEdit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIUc_selectKundenCustom : WpfCustom
    {
        
        public UIUc_selectKundenCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.selectKunden";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "uc_selectKunden";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIDg_listeTable UIDg_listeTable
        {
            get
            {
                if ((this.mUIDg_listeTable == null))
                {
                    this.mUIDg_listeTable = new UIDg_listeTable(this);
                }
                return this.mUIDg_listeTable;
            }
        }
        
        public WpfButton UISpeichernButton
        {
            get
            {
                if ((this.mUISpeichernButton == null))
                {
                    this.mUISpeichernButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUISpeichernButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_save";
                    this.mUISpeichernButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISpeichernButton;
            }
        }
        #endregion
        
        #region Fields
        private UIDg_listeTable mUIDg_listeTable;
        
        private WpfButton mUISpeichernButton;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIDg_listeTable : WpfTable
    {
        
        public UIDg_listeTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfTable.PropertyNames.AutomationId] = "dg_liste";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIItem1Row UIItem1Row
        {
            get
            {
                if ((this.mUIItem1Row == null))
                {
                    this.mUIItem1Row = new UIItem1Row(this);
                }
                return this.mUIItem1Row;
            }
        }
        #endregion
        
        #region Fields
        private UIItem1Row mUIItem1Row;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem1Row : WpfRow
    {
        
        public UIItem1Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfRow.PropertyNames.Name] = "1";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIAntenerCell UIAntenerCell
        {
            get
            {
                if ((this.mUIAntenerCell == null))
                {
                    this.mUIAntenerCell = new UIAntenerCell(this);
                }
                return this.mUIAntenerCell;
            }
        }
        #endregion
        
        #region Fields
        private UIAntenerCell mUIAntenerCell;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIAntenerCell : WpfCell
    {
        
        public UIAntenerCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Name";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfText UIAntenerText
        {
            get
            {
                if ((this.mUIAntenerText == null))
                {
                    this.mUIAntenerText = new WpfText(this);
                    #region Suchkriterien
                    this.mUIAntenerText.SearchProperties[WpfText.PropertyNames.Name] = "Antener";
                    this.mUIAntenerText.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIAntenerText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUIAntenerText;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIUc_selectFahrradCustom : WpfCustom
    {
        
        public UIUc_selectFahrradCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.selectFahrrad";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "uc_selectFahrrad";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIDg_listeTable1 UIDg_listeTable
        {
            get
            {
                if ((this.mUIDg_listeTable == null))
                {
                    this.mUIDg_listeTable = new UIDg_listeTable1(this);
                }
                return this.mUIDg_listeTable;
            }
        }
        
        public WpfButton UISpeichernButton
        {
            get
            {
                if ((this.mUISpeichernButton == null))
                {
                    this.mUISpeichernButton = new WpfButton(this);
                    #region Suchkriterien
                    this.mUISpeichernButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_save";
                    this.mUISpeichernButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISpeichernButton;
            }
        }
        #endregion
        
        #region Fields
        private UIDg_listeTable1 mUIDg_listeTable;
        
        private WpfButton mUISpeichernButton;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIDg_listeTable1 : WpfTable
    {
        
        public UIDg_listeTable1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfTable.PropertyNames.AutomationId] = "dg_liste";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIItem1Row1 UIItem1Row
        {
            get
            {
                if ((this.mUIItem1Row == null))
                {
                    this.mUIItem1Row = new UIItem1Row1(this);
                }
                return this.mUIItem1Row;
            }
        }
        #endregion
        
        #region Fields
        private UIItem1Row1 mUIItem1Row;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIItem1Row1 : WpfRow
    {
        
        public UIItem1Row1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfRow.PropertyNames.Name] = "1";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public UIScottCell UIScottCell
        {
            get
            {
                if ((this.mUIScottCell == null))
                {
                    this.mUIScottCell = new UIScottCell(this);
                }
                return this.mUIScottCell;
            }
        }
        #endregion
        
        #region Fields
        private UIScottCell mUIScottCell;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIScottCell : WpfCell
    {
        
        public UIScottCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WpfCell.PropertyNames.ColumnHeader] = "Hersteller";
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfText UIScottText
        {
            get
            {
                if ((this.mUIScottText == null))
                {
                    this.mUIScottText = new WpfText(this);
                    #region Suchkriterien
                    this.mUIScottText.SearchProperties[WpfText.PropertyNames.Name] = "Scott";
                    this.mUIScottText.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIScottText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUIScottText;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "14.0.23107.0")]
    public class UIMainWindowWindow1 : WinWindow
    {
        
        public UIMainWindowWindow1()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WinButton UISchließenButton
        {
            get
            {
                if ((this.mUISchließenButton == null))
                {
                    this.mUISchließenButton = new WinButton(this);
                    #region Suchkriterien
                    this.mUISchließenButton.SearchProperties[WinButton.PropertyNames.Name] = "Schließen";
                    this.mUISchließenButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUISchließenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISchließenButton;
        #endregion
    }
}
