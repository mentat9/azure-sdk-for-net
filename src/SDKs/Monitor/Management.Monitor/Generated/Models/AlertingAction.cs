// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specify action need to be taken when rule type is Alert
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.AlertingAction")]
    public partial class AlertingAction : Action
    {
        /// <summary>
        /// Initializes a new instance of the AlertingAction class.
        /// </summary>
        public AlertingAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertingAction class.
        /// </summary>
        /// <param name="severity">Severity of the alert. Possible values
        /// include: '0', '1', '2', '3', '4'</param>
        /// <param name="trigger">The trigger condition that results in the
        /// alert rule being.</param>
        /// <param name="aznsAction">Azure action group reference.</param>
        /// <param name="throttlingInMin">time (in minutes) for which Alerts
        /// should be throttled or suppressed.</param>
        public AlertingAction(string severity, TriggerCondition trigger, AzNsActionGroup aznsAction = default(AzNsActionGroup), int? throttlingInMin = default(int?))
        {
            Severity = severity;
            AznsAction = aznsAction;
            ThrottlingInMin = throttlingInMin;
            Trigger = trigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets severity of the alert. Possible values include: '0',
        /// '1', '2', '3', '4'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets azure action group reference.
        /// </summary>
        [JsonProperty(PropertyName = "aznsAction")]
        public AzNsActionGroup AznsAction { get; set; }

        /// <summary>
        /// Gets or sets time (in minutes) for which Alerts should be throttled
        /// or suppressed.
        /// </summary>
        [JsonProperty(PropertyName = "throttlingInMin")]
        public int? ThrottlingInMin { get; set; }

        /// <summary>
        /// Gets or sets the trigger condition that results in the alert rule
        /// being.
        /// </summary>
        [JsonProperty(PropertyName = "trigger")]
        public TriggerCondition Trigger { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Severity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Severity");
            }
            if (Trigger == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Trigger");
            }
            if (Trigger != null)
            {
                Trigger.Validate();
            }
        }
    }
}
