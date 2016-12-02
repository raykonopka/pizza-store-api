﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreAPI.Tests.PizzaStoreDataService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzaStoreDataService.IPizzaStoreDataService")]
    public interface IPizzaStoreDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetOrders", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetOrdersResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO[] GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetOrders", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetOrdersResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO[]> GetOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPaymentMethods", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPaymentMethodsResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.PaymentMethodDAO[] GetPaymentMethods();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPaymentMethods", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPaymentMethodsResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PaymentMethodDAO[]> GetPaymentMethodsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/PostNewOrder", ReplyAction="http://tempuri.org/IPizzaStoreDataService/PostNewOrderResponse")]
        bool PostNewOrder(PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO newOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/PostNewOrder", ReplyAction="http://tempuri.org/IPizzaStoreDataService/PostNewOrderResponse")]
        System.Threading.Tasks.Task<bool> PostNewOrderAsync(PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO newOrder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPizzas", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPizzasResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[] GetPizzas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPizzas", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPizzasResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[]> GetPizzasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPizzaSizes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPizzaSizesResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.PizzaSizeDAO[] GetPizzaSizes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPizzaSizes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPizzaSizesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PizzaSizeDAO[]> GetPizzaSizesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetCrustTypes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetCrustTypesResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.CrustTypeDAO[] GetCrustTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetCrustTypes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetCrustTypesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.CrustTypeDAO[]> GetCrustTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetSauceTypes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetSauceTypesResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.SauceTypeDAO[] GetSauceTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetSauceTypes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetSauceTypesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.SauceTypeDAO[]> GetSauceTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetCheeseTypes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetCheeseTypesResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.CheeseTypeDAO[] GetCheeseTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetCheeseTypes", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetCheeseTypesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.CheeseTypeDAO[]> GetCheeseTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppings", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingsResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.ToppingDAO[] GetToppings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppings", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingsResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingDAO[]> GetToppingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppingCategories", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingCategoriesResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.ToppingCategoryDAO[] GetToppingCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppingCategories", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingCategoriesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingCategoryDAO[]> GetToppingCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppingPlacements", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingPlacementsResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.ToppingPlacementDAO[] GetToppingPlacements();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppingPlacements", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingPlacementsResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingPlacementDAO[]> GetToppingPlacementsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppingLists", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingListsResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.ToppingListDAO[] GetToppingLists();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetToppingLists", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetToppingListsResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingListDAO[]> GetToppingListsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaStoreDataServiceChannel : PizzaStoreAPI.Tests.PizzaStoreDataService.IPizzaStoreDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaStoreDataServiceClient : System.ServiceModel.ClientBase<PizzaStoreAPI.Tests.PizzaStoreDataService.IPizzaStoreDataService>, PizzaStoreAPI.Tests.PizzaStoreDataService.IPizzaStoreDataService {
        
        public PizzaStoreDataServiceClient() {
        }
        
        public PizzaStoreDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaStoreDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaStoreDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaStoreDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO[] GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO[]> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.PaymentMethodDAO[] GetPaymentMethods() {
            return base.Channel.GetPaymentMethods();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PaymentMethodDAO[]> GetPaymentMethodsAsync() {
            return base.Channel.GetPaymentMethodsAsync();
        }
        
        public bool PostNewOrder(PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO newOrder) {
            return base.Channel.PostNewOrder(newOrder);
        }
        
        public System.Threading.Tasks.Task<bool> PostNewOrderAsync(PizzaStoreAPI.Service.PizzaStoreDataService.OrderDAO newOrder) {
            return base.Channel.PostNewOrderAsync(newOrder);
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[] GetPizzas() {
            return base.Channel.GetPizzas();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[]> GetPizzasAsync() {
            return base.Channel.GetPizzasAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.PizzaSizeDAO[] GetPizzaSizes() {
            return base.Channel.GetPizzaSizes();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PizzaSizeDAO[]> GetPizzaSizesAsync() {
            return base.Channel.GetPizzaSizesAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.CrustTypeDAO[] GetCrustTypes() {
            return base.Channel.GetCrustTypes();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.CrustTypeDAO[]> GetCrustTypesAsync() {
            return base.Channel.GetCrustTypesAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.SauceTypeDAO[] GetSauceTypes() {
            return base.Channel.GetSauceTypes();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.SauceTypeDAO[]> GetSauceTypesAsync() {
            return base.Channel.GetSauceTypesAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.CheeseTypeDAO[] GetCheeseTypes() {
            return base.Channel.GetCheeseTypes();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.CheeseTypeDAO[]> GetCheeseTypesAsync() {
            return base.Channel.GetCheeseTypesAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.ToppingDAO[] GetToppings() {
            return base.Channel.GetToppings();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingDAO[]> GetToppingsAsync() {
            return base.Channel.GetToppingsAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.ToppingCategoryDAO[] GetToppingCategories() {
            return base.Channel.GetToppingCategories();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingCategoryDAO[]> GetToppingCategoriesAsync() {
            return base.Channel.GetToppingCategoriesAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.ToppingPlacementDAO[] GetToppingPlacements() {
            return base.Channel.GetToppingPlacements();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingPlacementDAO[]> GetToppingPlacementsAsync() {
            return base.Channel.GetToppingPlacementsAsync();
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.ToppingListDAO[] GetToppingLists() {
            return base.Channel.GetToppingLists();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.ToppingListDAO[]> GetToppingListsAsync() {
            return base.Channel.GetToppingListsAsync();
        }
    }
}
