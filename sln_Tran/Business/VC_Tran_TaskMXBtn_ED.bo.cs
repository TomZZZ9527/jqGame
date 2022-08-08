using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

using DBLayer;
namespace UCMLCommon
{
    public partial class VC_Tran_TaskMXBtn_EDService : UCMLCommon.UCMLWSBPObject
    {
        private DataTable dsBC_Tran_TaskMX;
        private UCMLCommon.UseEntityClass dsBC_Tran_TaskMXBase;
        public VC_Tran_TaskMXBtn_EDService()
        {
            BPOName = "VC_Tran_TaskMXBtn_ED";
            LocalResourcePath = "../../../";
            OwnerFlow = "";
            OwnerActivity = "";
            InFlow = false;
            fSystemBPO = false;
            IsH5Page = true;
            IsMobilePage = false;
            fMutiLangugeSupport = false;
            fRegisterBPO = false;
            fEnableConfig = false;
            fFromActivityPermiss = false;
            fTransactionType = TransactionType.tsDB;
            InitializeComponent();
            if (busiAssemblyMode == BusiAssemblyMode.WeiService || busiAssemblyMode == BusiAssemblyMode.SingleWeiService)
            {
               Init();
            }
        }
        public VC_Tran_TaskMXBtn_EDService(bool fLocalClass):base(fLocalClass)
        {
            BPOName = "VC_Tran_TaskMXBtn_ED";
            LocalResourcePath = "../../../";
            OwnerFlow = "";
            OwnerActivity = "";
            InFlow = false;
            fSystemBPO = false;
            IsH5Page = true;
            IsMobilePage = false;
            fMutiLangugeSupport = false;
            fRegisterBPO = false;
            fEnableConfig = false;
            fFromActivityPermiss = false;
            fTransactionType = TransactionType.tsDB;
            InitializeComponent();
        }
    
      	#region Component Designer generated code
      	
      	//Web 服务设计器所必需的
      	private IContainer components = null;
      			
      	/// <summary>
      	/// 设计器支持所需的方法 - 不要使用代码编辑器修改
      	/// 此方法的内容。
      	/// </summary>
      	private void InitializeComponent()
      	{
      	}
      
      	/// <summary>
      	/// 清理所有正在使用的资源。
      	/// </summary>
      	protected override void Dispose( bool disposing )
      	{
      		if(disposing && components != null)
      		{
      			components.Dispose();
      		}
      		base.Dispose(disposing);		
      	}
      	
      	#endregion
       
        public UCMLCommon.BusinessColumn[] BC_Tran_TaskMXColumn;
        public UCMLCommon.BusinessColumn[] BC_Tran_TaskMXCondiColumn;
        UCMLCommon.BusinessColumn column;
        /// <summary>
        /// </summary>
        public DataTable BC_Tran_TaskMX
        {
            get
            {
                dsBC_Tran_TaskMX = this.BPODataSet.Tables["BC_Tran_TaskMX"];
                if (dsBC_Tran_TaskMX == null)
                {
                    dsBC_Tran_TaskMX = new DataTable("BC_Tran_TaskMX");
                    this.BPODataSet.Tables.Add(dsBC_Tran_TaskMX);
                }
                return dsBC_Tran_TaskMX;
            }
            set
            {
                dsBC_Tran_TaskMX = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public UCMLCommon.UseEntityClass BC_Tran_TaskMXBase
        {
            get
            {
                return dsBC_Tran_TaskMXBase;
            }
            set
            {
                dsBC_Tran_TaskMXBase = value;
            }
        }
        
        #region 业务组件初始化
        override public void RegisterUseTable()
        {
             BPOName = "VC_Tran_TaskMXBtn_ED";
            UseEntityArray = new UCMLCommon.UseEntityClass[1];
            UCMLCommon.UseEntityClass item;
            item = new UCMLCommon.UseEntityClass();
            BC_Tran_TaskMXBase = item;
            item.TableName = "Tran_TaskMX";
            item.ExtTableName = "";
            item.BCName = "BC_Tran_TaskMX";
            item.dataTable = BC_Tran_TaskMX;
            item.entityType = UCMLCommon.EntityType.MOTIF;
            item.Columns = BC_Tran_TaskMXColumn;
            item.condiColumns = BC_Tran_TaskMXCondiColumn;
            item.DBObjectType = typeof(DBLayer.Tran_TaskMX);
            item.DaoType = typeof(DBLayer.Tran_TaskMX);
            item.FieldInfoArray = BC_Tran_TaskMXColumn;
            item.DBType = UCMLCommon.DBType.MSSQL;
            item.Provider = UCMLCommon.DBProvider.MSSQLNA;
            item.DataOwnerType = (UCMLCommon.DataOwnerType)(0);
            item.DataAccessControlFieldName = "";
            item.CatalogFieldName = "";
            item.CatalogFieldValue = "";
            item.LinkKeyName = "";
            item.LinkKeyType = 46;
            item.PK_COLUMN_NAME = "";
            item.CascadeDeleteMode = 1;
            item.CascadeTableName = "";
            item.CascadeFKName = "";
            item.SelectLastFix = "";
            item.WhereLastFix = "";
            item.IsSODMode = false;
            item.IsReConnectNo = false;
            item.DBConnectionNo = 0;
            item.fTreeGridBC = false;
            item.IsDyColumns = false;
            item.ParentFieldName = "";
            item.fCustomerSQL = false;
            item.CustomerSQLSelect = "";
            item.AllowModifyJION = false;
            item.AllowModifyFK = "";
            item.fNumToString =  false;
            item.PageCount = 10;
            item.fNotReadData = false;
            item.IsRootBC = true;
            item.JoinInfo = new UCMLCommon.UCMLJoinInfo[0];
            item.BusiViewModes = new UCMLCommon.UCMLBusiViewMode[0];
            if (fLoalClass)
                item.BuildDataTableEx();
            if (item.dataTable.Columns.Count==0)
            {
                for ( int i=0; i<item.Columns.Length;i++)
                {
                    item.dataTable.Columns.Add(new DataColumn(item.Columns[i].FieldName, SystemTypeToCSharp(item,item.Columns[i].FieldType)));
                }
            }
            item.OnCustomPrepareCoulmns(FBPODataSet);
            item.fHaveUCMLKey = true;
            item.fIDENTITYKey = false;
            item.BaseKeyField = "Tran_TaskMXOID";
            UseEntityArray[0] = item;

                AppletLinkArray = new UCMLCommon.UCMLPortal.AppletLinkInfo[1];
                UCMLCommon.UCMLPortal.AppletLinkInfo appletLink = null;
                appletLink = new UCMLCommon.UCMLPortal.AppletLinkInfo();
                appletLink.AppletName = "VC_Tran_TaskMX_ED";
                appletLink.BCName = "BC_Tran_TaskMX";
                appletLink.Caption = "反馈记录";
                appletLink.Pane = "";
                appletLink.ParentField = "";
                appletLink.TreeCaptionField = "";
                appletLink.HaveCheck = false;
                appletLink.RootValueMode = 0;
                appletLink.RootValue = "";
                appletLink.VCKind = 164;
                appletLink.fTreeGridMode = false;
                appletLink.fSubTableTreeMode = false;
                appletLink.ImageLink = "";
                appletLink.SubBCs = "";
                appletLink.SubParentFields = "";
                appletLink.SubLabelFields = "";
                appletLink.SubPicFields = "";
                appletLink.SubFKFields = "";
                AppletLinkArray[0] = appletLink;
        }

        override protected void PreparePropertyList()
        {
            if (PropertyList.Columns.Count==0)
            {
            }
        }
        override protected void ReadPropertyList()
        {
            if (PropertyList.Columns.Count!=0)
            {
            }
        }
        override public void PrepareColumn()
        {
            BC_Tran_TaskMXColumn = LoadColumnFromXML("BC_Tran_TaskMX");
            if (BC_Tran_TaskMXColumn == null)
            {
                BC_Tran_TaskMXColumn = new UCMLCommon.BusinessColumn[19];
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Tran_TaskMXOID";
                column.fDisplay = false; 
                column.fCanModify = false; 
                column.Pos = 0;
                column.Width = 0;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "主键";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = false;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[0] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_Created";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 1;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 2;
                column.fGroupBy = false; 
                column.Caption = "创建日期";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[1] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_LAST_UPD";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 2;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "最后修改日期";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[2] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_Deleted";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 3;
                column.Width = 0;
                column.FieldType = 20;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "记录删除标记";
                column.EditType = "CHECKBOX";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[3] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "PersonName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 4;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "创建人";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[4] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "PostName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 5;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "创建岗位";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[5] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Division";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 6;
                column.Width = 100;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "创建部门";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[6] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "OrgName";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 7;
                column.Width = 100;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "创建单位";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[7] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "TaskMX_Type";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 8;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "类别";
                column.EditType = "INPUT";
                column.CodeTable = "Tran_TaskFeedbackCategory";
                column.fUseCodeTable = true;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[8] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Remark";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 9;
                column.Width = 500;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "描述";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[9] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "FinishState";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 10;
                column.Width = 50;
                column.FieldType = 2;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "完成状态";
                column.EditType = "INPUT";
                column.CodeTable = "Tran_TaskFinishState";
                column.fUseCodeTable = true;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[10] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "ActualFinish";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 11;
                column.Width = 0;
                column.FieldType = 33;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "实际完成时间";
                column.EditType = "DATEEDIT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "";
                column.LookupDataSet = "";
                column.LookupResultField = "";
                column.fForeignKey = false;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[11] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_CreatedBy";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 12;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "创建用户";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_UserOID";
                column.LookupDataSet = "UCML_User";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[12] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_REPLACEMENT";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 13;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "授权用户";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_UserOID";
                column.LookupDataSet = "UCML_User";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[13] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_POSTN";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 14;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "所属岗位";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_PostOID";
                column.LookupDataSet = "UCML_Post";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[14] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_DIVISION";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 15;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "所属部门";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_OrganizeOID";
                column.LookupDataSet = "UCML_Organize";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[15] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_ORG";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 16;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "所属组织";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_OrganizeOID";
                column.LookupDataSet = "UCML_Organize";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[16] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "SYS_LAST_UPD_BY";
                column.fDisplay = false; 
                column.fCanModify = true; 
                column.Pos = 17;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "最后修改用户";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "UCML_UserOID";
                column.LookupDataSet = "UCML_User";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[17] = column;
                column = new UCMLCommon.BusinessColumn();
                column.FieldName = "Tran_Task_FK";
                column.fDisplay = true; 
                column.fCanModify = true; 
                column.Pos = 18;
                column.Width = 30;
                column.FieldType = 46;
                column.StatMode = 0;
                column.SortMode = 0;
                column.fGroupBy = false; 
                column.Caption = "任务下达";
                column.EditType = "INPUT";
                column.CodeTable = "";
                column.fUseCodeTable = false;
                column.fAllowNull = true;
                column.CurrentPos = 0;
                column.DefaultValue = "";
                column.fAllowPick = false;
                column.ForeignKeyField = "";
                column.LookupKeyField = "Tran_TaskOID";
                column.LookupDataSet = "Tran_Task";
                column.LookupResultField = "";
                column.fForeignKey = true;
                column.FieldKind = 0;
    column.QueryRefColumn = "";
                column.ExcelColNo = 0;
                column.IsImageBase64Data = false;
                BC_Tran_TaskMXColumn[18] = column;
            }
        }
        #endregion
        /// <summary>
        /// 多维报表读取指标函数
        /// </summary>
        public void ReadFromKPISection()
        {
        }

        /// <summary>
        /// 多维报表保存指标函数
        /// </summary>
        public void WriteToKPISection()
        {
        }

        /// <summary>
        /// 读取流程状态数据
        /// </summary>
        override public void ReadDataFromFlow()
        {
        }

        /// <summary>
        /// 读取流程状态数据
        /// </summary>
        override public void ReadDataFromFlowEx()
        {
        }

        /// <summary>
        /// 保存流程状态数据
        /// </summary>
        override public void SaveDataToFlow()
        {
        }

        /// <summary>
        /// 业务初始化
        /// </summary>
        override protected void BusinessInit()
        {
            base.BusinessInit();

        }

        /// <summary>
        /// 业务提交后处理
        /// </summary>
        override protected void AfterBusinessSubmit()
        {


        }

    }
}
