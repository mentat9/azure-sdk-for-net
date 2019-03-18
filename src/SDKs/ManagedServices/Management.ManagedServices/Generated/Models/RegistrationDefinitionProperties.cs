// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a registration definition.
    /// </summary>
    public partial class RegistrationDefinitionProperties
    {
        /// <summary>
        /// Initializes a new instance of the RegistrationDefinitionProperties
        /// class.
        /// </summary>
        public RegistrationDefinitionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistrationDefinitionProperties
        /// class.
        /// </summary>
        /// <param name="authorizations">Authorization tuple containing
        /// prinicpal id of the user/security group or service principal and id
        /// of the build-in role.</param>
        /// <param name="managedByTenantId">Id of the managedBy tenant.</param>
        /// <param name="description">Description of the registration
        /// definition.</param>
        /// <param name="registrationDefinitionName">Name of the registration
        /// definition.</param>
        /// <param name="provisioningState">Current state of the registration
        /// definition. Possible values include: 'NotSpecified', 'Accepted',
        /// 'Running', 'Ready', 'Creating', 'Created', 'Deleting', 'Deleted',
        /// 'Canceled', 'Failed', 'Succeeded', 'Updating'</param>
        /// <param name="managedByTenantName">Name of the managedBy
        /// tenant.</param>
        public RegistrationDefinitionProperties(IList<Authorization> authorizations, string managedByTenantId, string description = default(string), string registrationDefinitionName = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), string managedByTenantName = default(string))
        {
            Description = description;
            Authorizations = authorizations;
            RegistrationDefinitionName = registrationDefinitionName;
            ManagedByTenantId = managedByTenantId;
            ProvisioningState = provisioningState;
            ManagedByTenantName = managedByTenantName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the registration definition.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets authorization tuple containing prinicpal id of the
        /// user/security group or service principal and id of the build-in
        /// role.
        /// </summary>
        [JsonProperty(PropertyName = "authorizations")]
        public IList<Authorization> Authorizations { get; set; }

        /// <summary>
        /// Gets or sets name of the registration definition.
        /// </summary>
        [JsonProperty(PropertyName = "registrationDefinitionName")]
        public string RegistrationDefinitionName { get; set; }

        /// <summary>
        /// Gets or sets id of the managedBy tenant.
        /// </summary>
        [JsonProperty(PropertyName = "managedByTenantId")]
        public string ManagedByTenantId { get; set; }

        /// <summary>
        /// Gets current state of the registration definition. Possible values
        /// include: 'NotSpecified', 'Accepted', 'Running', 'Ready',
        /// 'Creating', 'Created', 'Deleting', 'Deleted', 'Canceled', 'Failed',
        /// 'Succeeded', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets name of the managedBy tenant.
        /// </summary>
        [JsonProperty(PropertyName = "managedByTenantName")]
        public string ManagedByTenantName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Authorizations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Authorizations");
            }
            if (ManagedByTenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ManagedByTenantId");
            }
            if (Authorizations != null)
            {
                foreach (var element in Authorizations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
