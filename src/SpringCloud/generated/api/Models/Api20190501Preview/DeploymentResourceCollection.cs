namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Object that includes an array of App resources and a possible link for next set</summary>
    public partial class DeploymentResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResourceCollection,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResourceCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResource[] _value;

        /// <summary>Collection of Deployment resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DeploymentResourceCollection" /> instance.</summary>
        public DeploymentResourceCollection()
        {

        }
    }
    /// Object that includes an array of App resources and a possible link for next set
    public partial interface IDeploymentResourceCollection :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL client should use to fetch the next page (per server side paging).
        It's null for now, added for future use.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Collection of Deployment resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of Deployment resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResource[] Value { get; set; }

    }
    /// Object that includes an array of App resources and a possible link for next set
    public partial interface IDeploymentResourceCollectionInternal

    {
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>Collection of Deployment resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20190501Preview.IDeploymentResource[] Value { get; set; }

    }
}