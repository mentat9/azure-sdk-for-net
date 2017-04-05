// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Network.Fluent
{

    using NetworkInterface.Update;
    using Models;
    using NetworkInterface.Definition;
    using System.Collections.Generic;
    using ResourceManager.Fluent.Core.ResourceActions;
    using ResourceManager.Fluent;
    using ResourceManager.Fluent.Core;
    using System.Threading.Tasks;
    using System.Threading;

    /// <summary>
    /// Implementation for NetworkInterface and its create and update interfaces.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50Lm5ldHdvcmsuaW1wbGVtZW50YXRpb24uTmV0d29ya0ludGVyZmFjZUltcGw=
    internal partial class NetworkInterfaceImpl :
        GroupableParentResource<INetworkInterface,
                NetworkInterfaceInner,
                NetworkInterfaceImpl,
                INetworkManager,
                IWithGroup,
                IWithPrimaryNetwork,
                IWithCreate,
                IUpdate>,
            INetworkInterface,
            IDefinition,
            IUpdate

    {
        // the name of the network interface.
        private string nicName;
        // reference to the primary ip configuration.
        private NicIPConfigurationImpl nicPrimaryIPConfiguration;
        // references to all ip configuration.
        private IDictionary<string, INicIPConfiguration> nicIPConfigurations;
        // unique key of a creatable network security group to be associated with the network interface.
        private string creatableNetworkSecurityGroupKey;
        // reference to an network security group to be associated with the network interface.
        private INetworkSecurityGroup existingNetworkSecurityGroupToAssociate;
        // cached related resources.
        private INetworkSecurityGroup networkSecurityGroup;
        // used to generate unique name for any dependency resources.
        protected IResourceNamer namer;

        ///GENMHASH:5C85B818743A5F30E309A5379B6A9A34:C0C9B388307AE67BE8D9EE6E90296330
        internal NetworkInterfaceImpl(string name, NetworkInterfaceInner innerModel, INetworkManager networkManager)
            : base(name, innerModel, networkManager)
        {
            nicName = name;
            namer = SdkContext.CreateResourceNamer(nicName);
            InitializeChildrenFromInner();
        }

        ///GENMHASH:3FAB18211D6DAAAEF5CA426426D16F0C:D3E6D518478DF49EC6C53F1D88A60E52
        internal NetworkInterfaceImpl WithNewPrimaryNetwork(ICreatable<INetwork> creatable)
        {
            PrimaryIPConfiguration().WithNewNetwork(creatable);
            return this;
        }

        ///GENMHASH:0994141806BE37BB879E10A9CBFBE5DD:A423F6A8178D9D4AD5FFBD89D474E9F5
        internal NetworkInterfaceImpl WithNewPrimaryNetwork(string name, string addressSpaceCidr)
        {
            PrimaryIPConfiguration().WithNewNetwork(name, addressSpaceCidr);
            return this;
        }

        ///GENMHASH:4002186478A1CB0B59732EBFB18DEB3A:BCF4C230F6F0AA0BE6D9C038631B4B67
        public override INetworkInterface Refresh()
        {
            var response = Manager.Inner.NetworkInterfaces.Get(ResourceGroupName, nicName);
            SetInner(response);
            return this;
        }

        ///GENMHASH:C8A4DDE66256242DF61087375BF710B0:78F3FE05E98D67CD9C4262D01BCC8B46
        internal NetworkInterfaceImpl WithNewPrimaryNetwork(string addressSpaceCidr)
        {
            PrimaryIPConfiguration().WithNewNetwork(addressSpaceCidr);
            return this;
        }

        ///GENMHASH:EE2847D8AC43E9B7C3BFB967F80560D4:750FFABBA4314035DF1B70FBF6EC576B
        internal NetworkInterfaceImpl WithExistingPrimaryNetwork(INetwork network)
        {
            PrimaryIPConfiguration().WithExistingNetwork(network);
            return this;
        }

        ///GENMHASH:12E96FEFBC60AB582A0B69EBEEFD1E59:E859048650F24046830CC24E348A0001
        internal NetworkInterfaceImpl WithNewPrimaryPublicIPAddress(ICreatable<IPublicIPAddress> creatable)
        {
            PrimaryIPConfiguration().WithNewPublicIPAddress(creatable);
            return this;
        }

        ///GENMHASH:5C816AA86EABCE4D1E9AA2582BB7D4FC:52D3C12B3F2D793FE3DD69A9E175AF71
        internal NetworkInterfaceImpl WithNewPrimaryPublicIPAddress()
        {
            PrimaryIPConfiguration().WithNewPublicIPAddress();
            return this;
        }

        ///GENMHASH:BA50EF0AC88D5405DFE18FCE26A595B2:9BD8717AEF47F0B40F0C49540F01A1B2
        internal NetworkInterfaceImpl WithNewPrimaryPublicIPAddress(string leafDnsLabel)
        {
            PrimaryIPConfiguration().WithNewPublicIPAddress(leafDnsLabel);
            return this;
        }

        ///GENMHASH:D36B69B83A3C752672806F0242C22209:03C9A45B7DD0369F04FBC19AD645F622
        internal NetworkInterfaceImpl WithExistingLoadBalancerBackend(ILoadBalancer loadBalancer, string backendName)
        {
            PrimaryIPConfiguration().WithExistingLoadBalancerBackend(loadBalancer, backendName);
            return this;
        }

        ///GENMHASH:03CBA85933E5B90121E4F4AE70F457EE:C90E3AF2D1A6D3B28206FAB8C529424C
        internal NetworkInterfaceImpl WithExistingLoadBalancerInboundNatRule(ILoadBalancer loadBalancer, string inboundNatRuleName)
        {
            PrimaryIPConfiguration().WithExistingLoadBalancerInboundNatRule(loadBalancer, inboundNatRuleName);
            return this;
        }

        ///GENMHASH:6CB02C98B1D9201E95334813294DA523:F2BACBE27F5D505AA71F0FE676EF5720
        internal IUpdate WithoutLoadBalancerBackends()
        {
            ///GENMHASH:8535B0E23E6704558262509B5A55B45D:CE76D91B778968B2CC0465313DF6F3F6
            foreach (var ipConfig in IPConfigurations().Values)
            {
                UpdateIPConfiguration(ipConfig.Name)
                   .WithoutLoadBalancerBackends();
            }

            return this;
        }

        ///GENMHASH:8B463B99540F7AFAB4F1D7B5D595864D:B5571258C8DD77A073FC3863C188426E
        internal IUpdate WithoutLoadBalancerInboundNatRules()
        {
            foreach (var ipConfig in IPConfigurations().Values)
            {
                UpdateIPConfiguration(ipConfig.Name)
                    .WithoutLoadBalancerInboundNatRules();
            }

            return this;
        }

        ///GENMHASH:D0AB91F51DBDFA04880ED371AD9E48EE:42B9E6B3BAA44EA33B4EAF5ED78B85FA
        internal NetworkInterfaceImpl WithoutPrimaryPublicIPAddress()
        {
            PrimaryIPConfiguration().WithoutPublicIPAddress();
            return this;
        }

        ///GENMHASH:2B7C2F1E86A359473717299AD4D4DCBA:F737496F62EBDB341B8A5449D37F2184
        internal NetworkInterfaceImpl WithExistingPrimaryPublicIPAddress(IPublicIPAddress publicIPAddress)
        {
            PrimaryIPConfiguration().WithExistingPublicIPAddress(publicIPAddress);
            return this;
        }

        ///GENMHASH:022FCEBED3C6606D834C45EAD65C0D6F:AB5111B32426DE6983DC4B6CA0F1EBD7
        internal NetworkInterfaceImpl WithPrimaryPrivateIPAddressDynamic()
        {
            PrimaryIPConfiguration().WithPrivateIPAddressDynamic();
            return this;
        }

        ///GENMHASH:655D6F837286729FEB47BD78B3EB9A08:282F12C5EC57C36AEED5D73EE80CCA21
        internal NetworkInterfaceImpl WithPrimaryPrivateIPAddressStatic(string staticPrivateIPAddress)
        {
            PrimaryIPConfiguration().WithPrivateIPAddressStatic(staticPrivateIPAddress);
            return this;
        }

        ///GENMHASH:57034924A790F6746C59AFD837045739:49734EEA751CB09B1B581F6F3AC76156
        internal NetworkInterfaceImpl WithNewNetworkSecurityGroup(ICreatable<INetworkSecurityGroup> creatable)
        {
            if (creatableNetworkSecurityGroupKey == null)
            {
                creatableNetworkSecurityGroupKey = creatable.Key;
                AddCreatableDependency(creatable as IResourceCreator<IHasId>);
            }

            return this;
        }

        ///GENMHASH:9BCDEB79AFC04D55B9BC280847723DFC:7E388FA346F0E33887182060FBAF25FB
        internal NetworkInterfaceImpl WithExistingNetworkSecurityGroup(INetworkSecurityGroup networkSecurityGroup)
        {
            existingNetworkSecurityGroupToAssociate = networkSecurityGroup;
            return this;
        }

        ///GENMHASH:31626FBDA69232B7DD9945ADF14E191A:245758B25F0370039EC9345CF6DFAC4C
        internal NetworkInterfaceImpl WithoutNetworkSecurityGroup()
        {
            Inner.NetworkSecurityGroup = null;
            return this;
        }

        ///GENMHASH:A04F7DC458E3AAEECFC1B7ED7A839D25:D89F8C33F0F7212B41798D8320402C53
        internal NicIPConfigurationImpl DefineSecondaryIPConfiguration(string name)
        {
            return PrepareNewNicIPConfiguration(name);
        }

        ///GENMHASH:405FE49F57EE4AB4C0F91D84030D1DDA:29B7D63ED2C33F842B340E1808C46918
        internal NicIPConfigurationImpl UpdateIPConfiguration(string name)
        {
            return (NicIPConfigurationImpl)nicIPConfigurations[name];
        }

        ///GENMHASH:54C012D1DF6347D810187D83D172084B:BC7B9CE4DF8F5CF674BD242D689847EB
        internal NetworkInterfaceImpl WithIPForwarding()
        {
            Inner.EnableIPForwarding = true;
            return this;
        }

        ///GENMHASH:A3E0AFFD41A48AADA625D444BDC4B639:B533E6AC21591D01AE3A4444FFF05CC7
        internal NetworkInterfaceImpl WithoutIPConfiguration(string name)
        {
            nicIPConfigurations.Remove(name);
            return this;
        }

        ///GENMHASH:4BD72D8B5B6B7BE1DC4C51859392E53D:2E1455D3F01711104A5EEA9DD0BD0D37
        internal NetworkInterfaceImpl WithoutIPForwarding()
        {
            Inner.EnableIPForwarding = false;
            return this;
        }

        ///GENMHASH:C46E686F6BFED9BDC32DE6EB942E24F4:81A5EA74AB5B9AA1B34EEF4EA62E2D96
        internal NetworkInterfaceImpl WithDnsServer(string ipAddress)
        {
            DnsServerIPs.Add(ipAddress);
            return this;
        }

        ///GENMHASH:BE22C0B9325B4C1589049D401C88C656:BAEDCA14BB8BD16A981A0ACC904CC1DF
        internal NetworkInterfaceImpl WithoutDnsServer(string ipAddress)
        {
            DnsServerIPs.Remove(ipAddress);
            return this;
        }

        ///GENMHASH:B5D0BEC334A2545AEB57083EF9E7D3D8:5F53E33DB28637049C670A13BBF9EB02
        internal NetworkInterfaceImpl WithAzureDnsServer()
        {
            DnsServerIPs.Clear();
            return this;
        }

        ///GENMHASH:0FBBECB150CBC82F165D8BA614AB135A:3BE65638D99459AEB33D964ACC8FE7C3
        internal NetworkInterfaceImpl WithSubnet(string name)
        {
            PrimaryIPConfiguration().WithSubnet(name);
            return this;
        }

        ///GENMHASH:FDFBE4AC2A815BC5ED9C61213C2A6070:450E9FE3E20364B98D321B9668124A61
        internal NetworkInterfaceImpl WithInternalDnsNameLabel(string dnsNameLabel)
        {
            Inner.DnsSettings.InternalDnsNameLabel = dnsNameLabel;
            return this;
        }

        ///GENMHASH:3E35FB42190F8D9DBB9DAD636FA3EDE3:687D257893DF69A84BCC9D6FC3EA33D5
        internal string VirtualMachineId()
        {
            return (Inner.VirtualMachine != null) ? Inner.VirtualMachine.Id : null;
        }

        ///GENMHASH:B067E306CF42399044F34EA78189F196:8574363DCCF2F083DA5ADD2B4079AAAA
        internal bool IsIPForwardingEnabled()
        {
            return (Inner.EnableIPForwarding.HasValue) ? Inner.EnableIPForwarding.Value : false;
        }

        ///GENMHASH:58FE825A07E34384FA845B00D2554839:C3490FB601F6C84962573C9CA536B1DE
        internal string MacAddress()
        {
            return Inner.MacAddress;
        }

        ///GENMHASH:349C4E09DD850CE224A3467EF70DD6FF:A93BB7B6EE2CF70BA8CD229E2D28058E
        internal string InternalDnsNameLabel()
        {
            return (Inner.DnsSettings != null) ? Inner.DnsSettings.InternalDnsNameLabel : null;
        }

        ///GENMHASH:E0135EB00D1A398C77458FC7B4F10581:32E851D3244AD103A5EAB9B002E22D0C
        internal string InternalDomainNameSuffix()
        {
            return (Inner.DnsSettings != null) ? Inner.DnsSettings.InternalDomainNameSuffix : null;
        }

        ///GENMHASH:9647B31AF7C6E31D3F4BB97FF05EB53A:09E7A363E9118CFD8751EA41C3C67496
        internal IList<string> AppliedDnsServers()
        {
            List<string> dnsServers = new List<string>();
            if (Inner.DnsSettings == null)
                return dnsServers;
            else if (Inner.DnsSettings.AppliedDnsServers == null)
                return dnsServers;
            else
                return Inner.DnsSettings.AppliedDnsServers;
        }

        ///GENMHASH:F024226BEBD3E09E89CF44CD0AC59AE1:E07E902BD7AB49BA796B3A335B6D2AA0
        internal string InternalFqdn()
        {
            return (Inner.DnsSettings != null) ? Inner.DnsSettings.InternalFqdn : null;
        }

        ///GENMHASH:B1AD13DA0902D51846B309BF1324B456:6B6A10392C3993A13073D7558F87E5B2
        internal IList<string> DnsServers()
        {
            return DnsServerIPs;
        }

        ///GENMHASH:BABDA7E43134C76FA5F4A73696B36B74:3380FF133D1D152807CFB1362566EA86
        internal string PrimaryPrivateIP()
        {
            return PrimaryIPConfiguration().PrivateIPAddress();
        }

        ///GENMHASH:7553B8041F1BC45ED58133F4644155F7:2044126CDE4657E10D6C6D7C5D923AFF
        internal IPAllocationMethod PrimaryPrivateIPAllocationMethod()
        {
            return PrimaryIPConfiguration().PrivateIPAllocationMethod();
        }

        internal IDictionary<string, INicIPConfiguration> IPConfigurations()
        {
            return nicIPConfigurations;
        }

        ///GENMHASH:A9777D8010E6AF7B603113E49858FE75:0A1C32015C3FE7888D450702542868EA
        internal string NetworkSecurityGroupId()
        {
            return (Inner.NetworkSecurityGroup != null) ? Inner.NetworkSecurityGroup.Id : null;
        }

        ///GENMHASH:2E4015B29759BBD97527EBAE809B083C:6C3CAD274F4DB3A7B0A759C3BFF8A0EE
        internal INetworkSecurityGroup GetNetworkSecurityGroup()
        {
            if (networkSecurityGroup == null && NetworkSecurityGroupId() != null)
            {
                string id = NetworkSecurityGroupId();
                networkSecurityGroup = Manager
                    .NetworkSecurityGroups
                    .GetByResourceGroup(ResourceUtils.GroupFromResourceId(id), ResourceUtils.NameFromResourceId(id));
            }
            return networkSecurityGroup;
        }

        /// <returns>the primary IP configuration of the network interface</returns>

        ///GENMHASH:3112993FF79864659400569FD226EA9E:267DFA5CED90051075D45C55F7FC0ABD
        internal NicIPConfigurationImpl PrimaryIPConfiguration()
        {
            if (nicPrimaryIPConfiguration != null)
            {
                return nicPrimaryIPConfiguration;
            }

            if (IsInCreateMode)
            {
                nicPrimaryIPConfiguration = PrepareNewNicIPConfiguration("primary");
                WithIPConfiguration(nicPrimaryIPConfiguration);
            }
            else
            {
                // TODO: Currently Azure supports only one IP configuration and that is the primary
                // hence we pick the first one here.
                // when Azure support multiple IP configurations then there will be a flag in
                // the IPConfiguration or a property in the network interface to identify the
                // primary so below logic will be changed.
                nicPrimaryIPConfiguration = (NicIPConfigurationImpl)new List<INicIPConfiguration>(
                    nicIPConfigurations.Values)[0];
            }
            return nicPrimaryIPConfiguration;
        }

        /// <returns>the list of DNS server IPs from the DNS settings</returns>

        ///GENMHASH:08B7E1E5C1AFE7A46CE9F049D5CDA430:C8A1E211AE92B97C661E3D7541994267
        private IList<string> DnsServerIPs
        {
            get
            {
                List<string> dnsServers = new List<string>();
                if (Inner.DnsSettings == null)
                    return dnsServers;
                else if (Inner.DnsSettings.DnsServers == null)
                    return dnsServers;
                else
                    return Inner.DnsSettings.DnsServers;
            }
        }

        ///GENMHASH:6D9F740D6D73C56877B02D9F1C96F6E7:B8B4529F45579E69075A666EABB488A7
        override protected void InitializeChildrenFromInner()
        {
            nicIPConfigurations = new Dictionary<string, INicIPConfiguration>();
            IList<NetworkInterfaceIPConfigurationInner> inners = Inner.IpConfigurations;
            if (inners != null)
            {
                foreach (NetworkInterfaceIPConfigurationInner inner in inners)
                {
                    NicIPConfigurationImpl nicIPConfiguration = new NicIPConfigurationImpl(inner, this, Manager, false);
                    nicIPConfigurations.Add(nicIPConfiguration.Name(), nicIPConfiguration);
                }
            }
        }

        /// <summary>
        /// Gets a new IP configuration child resource NicIPConfiguration wrapping NetworkInterfaceIPConfigurationInner.
        /// </summary>
        /// <param name="name">name the name for the new ip configuration</param>
        /// <returns>NicIPConfiguration</returns>

        ///GENMHASH:C2E275E9E7942CEA349C5BB45AC39F3F:680A69F57A8E292A1C8AEE72C51E4DAA
        private NicIPConfigurationImpl PrepareNewNicIPConfiguration(string name)
        {
            NicIPConfigurationImpl nicIPConfiguration = NicIPConfigurationImpl.PrepareNicIPConfiguration(name, this, Manager);
            return nicIPConfiguration;
        }

        ///GENMHASH:7F6A7E961EA5A11F2B8013E54123A7D0:76DD4E65A95BB0B5F96BE7271C9649BA
        private void ClearCachedRelatedResources()
        {
            networkSecurityGroup = null;
            nicPrimaryIPConfiguration = null;
        }

        ///GENMHASH:67AE4BFF598410C6FA5B8B8386E40191:5FF05143CFAD88667A0F427BE8477F86
        internal NetworkInterfaceImpl WithIPConfiguration(NicIPConfigurationImpl nicIPConfiguration)
        {
            nicIPConfigurations.Add(nicIPConfiguration.Name(), nicIPConfiguration);
            return this;
        }

        ///GENMHASH:94051374E70252DDB3C7A3FEDAA8537B:FC7B116552CE8C8D172AF7124F9B7092
        internal void AddToCreatableDependencies(IResourceCreator<IHasId> creatableResource)
        {
            AddCreatableDependency(creatableResource);
        }

        ///GENMHASH:C67758EF2E365B570BC697E1F615237E:D9E5129DA20E099859BE4DEE002923C8
        internal IHasId CreatedDependencyResource(string key)
        {
            return CreatedResource(key);
        }

        ///GENMHASH:30845DAECBF61D7211678C9DC6EC7B14:80D31269AE598B94897682B4DE95A6D1
        internal ICreatable<IResourceGroup> NewGroup()
        {
            return newGroup;
        }

        ///GENMHASH:359B78C1848B4A526D723F29D8C8C558:7501824DEE4570F3E78F9698BA2828B0
        protected async override Task<NetworkInterfaceInner> CreateInnerAsync(CancellationToken cancellationToken)
        {
            return await Manager.Inner.NetworkInterfaces.CreateOrUpdateAsync(ResourceGroupName, Name, Inner, cancellationToken);
        }

        ///GENMHASH:F91F57741BB7E185BF012523964DEED0:26BB61AD1C4F8E3F1AD2EA55120B6EE2
        override protected void AfterCreating()
        {
            ClearCachedRelatedResources();
        }

        ///GENMHASH:AC21A10EE2E745A89E94E447800452C1:85DD90F53CAD1178E29833ACA9B92244
        override protected void BeforeCreating()
        {
            INetworkSecurityGroup networkSecurityGroup = null;
            if (creatableNetworkSecurityGroupKey != null)
            {
                networkSecurityGroup = (INetworkSecurityGroup)this.CreatedResource(creatableNetworkSecurityGroupKey);
            }
            else if (existingNetworkSecurityGroupToAssociate != null)
            {
                networkSecurityGroup = existingNetworkSecurityGroupToAssociate;
            }

            // Associate an NSG if needed
            if (networkSecurityGroup != null)
            {
                Inner.NetworkSecurityGroup =
                    ///GENMHASH:B6961E0C7CB3A9659DE0E1489F44A936:0B871D5CC01C5634C2C9305DF6429EF2
                    Manager.NetworkSecurityGroups.GetById(networkSecurityGroup.Id).Inner;
            }

            NicIPConfigurationImpl.EnsureConfigurations(new List<INicIPConfiguration>(nicIPConfigurations.Values));

            // Reset and update IP configs
            Inner.IpConfigurations =
                InnersFromWrappers<NetworkInterfaceIPConfigurationInner, INicIPConfiguration>(nicIPConfigurations.Values);
        }
    }
}