
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.JSInterop;
namespace BlazingPizza.Client;



    public class OrderState
    {
        private readonly IJSRuntime _jsRuntime;
        private const string OrderStorageKey = "BlazingPizza_Order";

        public bool ShowingConfigureDialog { get; private set; }

        public Pizza? ConfiguringPizza { get; private set; }

        public Order Order { get; private set; } = new Order();

       // public CreditCard? CreditCard { get; set; } = new CreditCard();


        

        public OrderState(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            LoadOrderFromStorage();
        }

        public void ShowConfigurePizzaDialog(PizzaSpecial special)
        {
            ConfiguringPizza = new Pizza()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>(),
            };

            ShowingConfigureDialog = true;
        }

        public void CancelConfigurePizzaDialog()
        {
            ConfiguringPizza = null;
            ShowingConfigureDialog = false;
        }

        public void ConfirmConfigurePizzaDialog()
        {
            if (ConfiguringPizza is not null)
            {
                Order.Pizzas.Add(ConfiguringPizza);
                ConfiguringPizza = null;
                SaveOrderToStorage(); // Save order after confirming pizza configuration
            }

            ShowingConfigureDialog = false;
        }

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
            SaveOrderToStorage(); // Save order after removing pizza
        }

        public void ResetOrder()
        {
            Order = new Order();
            SaveOrderToStorage(); // Save order after resetting
        }

        public void ReplaceOrder(Order order)
        {
            Order = order;
            SaveOrderToStorage(); // Save order after replacing
        }

        private async void LoadOrderFromStorage()
        {
            try
            {
                var orderJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", OrderStorageKey);
                if (!string.IsNullOrWhiteSpace(orderJson))
                {
                    Order = Newtonsoft.Json.JsonConvert.DeserializeObject<Order>(orderJson);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        private async void SaveOrderToStorage()
        {
            try
            {
                var orderJson = Newtonsoft.Json.JsonConvert.SerializeObject(Order);
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", OrderStorageKey, orderJson);
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }


    }

