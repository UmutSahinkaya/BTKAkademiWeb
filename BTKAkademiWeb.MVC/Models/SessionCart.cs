using System.Text.Json.Serialization;
using BTKAkademiWeb.MVC.Infrastructe.Extensions;
using Entities.Models;
using BTKAkademiWeb.MVC.Infrastructe.Extensions;

namespace BTKAkademiWeb.MVC.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession? Session { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()
                .HttpContext?.Session;

            SessionCart cart = session?.GetJson<SessionCart>("cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session?.SetJson<SessionCart>("cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session?.Remove("cart");
        }

        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session?.SetJson<SessionCart>("cart", this);
        }
    }
}