// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A product summary resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProductSummary : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProductSummary class.
        /// </summary>
        public ProductSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductSummary class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The display name of the product.</param>
        /// <param name="purchaseDate">The date of purchase.</param>
        /// <param name="productTypeId">The product type id.</param>
        /// <param name="productType">The type of product.</param>
        /// <param name="status">Product status. Possible values include:
        /// 'Active', 'Inactive', 'PastDue', 'Expiring', 'Expired', 'Disabled',
        /// 'Cancelled', 'AutoRenew'</param>
        /// <param name="endDate">end date.</param>
        /// <param name="billingFrequency">Billing frequency. Possible values
        /// include: 'OneTime', 'Monthly', 'UsageBased'</param>
        /// <param name="lastCharge">Last month charges.</param>
        /// <param name="lastChargeDate">The date of the last charge.</param>
        /// <param name="quantity">The purchased product quantity.</param>
        /// <param name="skuId">Sku Id.</param>
        /// <param name="skuDescription">Sku description.</param>
        /// <param name="availabilityId">Availability Id.</param>
        /// <param name="parentProductId">Parent Product Id.</param>
        /// <param name="invoiceSectionId">Invoice section id to which this
        /// product belongs.</param>
        /// <param name="invoiceSectionName">Invoice section name to which this
        /// product belongs.</param>
        /// <param name="billingProfileId">Billing Profile id to which this
        /// product belongs.</param>
        /// <param name="billingProfileName">Billing Profile name to which this
        /// product belongs.</param>
        public ProductSummary(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), System.DateTime? purchaseDate = default(System.DateTime?), string productTypeId = default(string), string productType = default(string), string status = default(string), System.DateTime? endDate = default(System.DateTime?), string billingFrequency = default(string), Amount lastCharge = default(Amount), System.DateTime? lastChargeDate = default(System.DateTime?), double? quantity = default(double?), string skuId = default(string), string skuDescription = default(string), string availabilityId = default(string), string parentProductId = default(string), string invoiceSectionId = default(string), string invoiceSectionName = default(string), string billingProfileId = default(string), string billingProfileName = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            PurchaseDate = purchaseDate;
            ProductTypeId = productTypeId;
            ProductType = productType;
            Status = status;
            EndDate = endDate;
            BillingFrequency = billingFrequency;
            LastCharge = lastCharge;
            LastChargeDate = lastChargeDate;
            Quantity = quantity;
            SkuId = skuId;
            SkuDescription = skuDescription;
            AvailabilityId = availabilityId;
            ParentProductId = parentProductId;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionName = invoiceSectionName;
            BillingProfileId = billingProfileId;
            BillingProfileName = billingProfileName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the display name of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the date of purchase.
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchaseDate")]
        public System.DateTime? PurchaseDate { get; private set; }

        /// <summary>
        /// Gets the product type id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productTypeId")]
        public string ProductTypeId { get; private set; }

        /// <summary>
        /// Gets the type of product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productType")]
        public string ProductType { get; private set; }

        /// <summary>
        /// Gets or sets product status. Possible values include: 'Active',
        /// 'Inactive', 'PastDue', 'Expiring', 'Expired', 'Disabled',
        /// 'Cancelled', 'AutoRenew'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets end date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endDate")]
        public System.DateTime? EndDate { get; private set; }

        /// <summary>
        /// Gets or sets billing frequency. Possible values include: 'OneTime',
        /// 'Monthly', 'UsageBased'
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingFrequency")]
        public string BillingFrequency { get; set; }

        /// <summary>
        /// Gets last month charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCharge")]
        public Amount LastCharge { get; private set; }

        /// <summary>
        /// Gets the date of the last charge.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastChargeDate")]
        public System.DateTime? LastChargeDate { get; private set; }

        /// <summary>
        /// Gets the purchased product quantity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public double? Quantity { get; private set; }

        /// <summary>
        /// Gets sku Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuId")]
        public string SkuId { get; private set; }

        /// <summary>
        /// Gets sku description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuDescription")]
        public string SkuDescription { get; private set; }

        /// <summary>
        /// Gets availability Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilityId")]
        public string AvailabilityId { get; private set; }

        /// <summary>
        /// Gets parent Product Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parentProductId")]
        public string ParentProductId { get; private set; }

        /// <summary>
        /// Gets invoice section id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets invoice section name to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionName")]
        public string InvoiceSectionName { get; private set; }

        /// <summary>
        /// Gets billing Profile id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing Profile name to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileName")]
        public string BillingProfileName { get; private set; }

    }
}
