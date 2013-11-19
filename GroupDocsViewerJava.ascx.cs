using System;
using CMS.PortalControls;
using CMS.GlobalHelper;

public partial class CMSWebParts_GroupDocsViewerJava_GroupDocsViewerJava : CMSAbstractWebPart
{
    #region Properties

    /// <summary>
    /// Get or set document Url
    /// </summary>
    public string Url
    {
        get
        {
            return DataHelper.GetNotEmpty(GetValue("Url"), String.Empty);
        }
        set
        {
            SetValue("Url", value);
        }
    }

    /// <summary>
    /// Get or set document Width
    /// </summary>
    public string Width
    {
        get
        {
            return DataHelper.GetNotEmpty(GetValue("Width"), "100%");
        }
        set
        {
            SetValue("Width", value);
        }
    }

    /// <summary>
    /// Get or set html iframe Height
    /// </summary>
    public string Height
    {
        get
        {
            return DataHelper.GetNotEmpty(GetValue("Height"), "600px");
        }
        set
        {
            SetValue("Height", value);
        }
    }

    /// <summary>
    /// Get or set html iframe DefaultFileName
    /// </summary>
    public string DefaultFileName
    {
        get
        {
            return DataHelper.GetNotEmpty(GetValue("DefaultFileName"), string.Empty);
        }
        set
        {
            SetValue("DefaultFileName", value);
        }
    }

    /// <summary>
    /// Get or set html iframe UseHttpHandlers
    /// </summary>
    public bool UseHttpHandlers
    {
        get
        {
            return Boolean.Parse(DataHelper.GetNotEmpty(GetValue("UseHttpHandlers"), Boolean.TrueString));
        }
        set
        {
            SetValue("UseHttpHandlers", value);
        }
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.DataBind();
        Page.Page.DataBind();
    }
}