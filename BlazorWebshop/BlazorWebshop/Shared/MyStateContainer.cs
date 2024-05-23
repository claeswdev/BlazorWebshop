using BlazorWebshop.Models;

namespace BlazorWebshop.Shared
{
    public class MyStateContainer
    {
        public Customer? Value { get; set; }
        public event Action? OnStateChange;
        public void SetValue(Customer value)
        {
            this.Value = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
