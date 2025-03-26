using System;
using System.Collections.Generic;
using System.Linq;

// 订单明细类
public class OrderDetails
{
    public Goods Product { get; set; } // 商品
    public int Quantity { get; set; } // 数量
    public double TotalPrice => Product.Price * Quantity; // 计算总价

    // 重写Equals方法，确保订单明细不重复
    public override bool Equals(object obj)
    {
        if (obj is OrderDetails details)
        {
            return Product.Equals(details.Product);
        }
        return false;
    }
    public override int GetHashCode() => Product.GetHashCode();
    public override string ToString() => $"{Product.Name} x {Quantity}, 总价: {TotalPrice}";
}

// 货物类
public class Goods
{
    public string Name { get; set; } // 商品名称
    public double Price { get; set; } // 价格
    public override bool Equals(object obj) => obj is Goods goods && Name == goods.Name;
    public override int GetHashCode() => Name.GetHashCode();
    public override string ToString() => $"商品: {Name}, 价格: {Price}";
}

// 客户类
public class Customer
{
    public string Name { get; set; } // 客户名称
    public override string ToString() => $"客户: {Name}";
}

// 订单类
public class Order
{
    public int OrderId { get; set; } // 订单号
    public Customer Customer { get; set; } // 订单所属客户
    public List<OrderDetails> Details { get; set; } = new List<OrderDetails>(); // 订单明细
    public double TotalAmount => Details.Sum(d => d.TotalPrice); // 计算订单总金额（使用LINQ）

    // 重写Equals方法，确保订单不重复
    public override bool Equals(object obj) => obj is Order order && OrderId == order.OrderId;
    public override int GetHashCode() => OrderId.GetHashCode();
    public override string ToString() => $"订单号: {OrderId}, {Customer}, 总金额: {TotalAmount}";
}

// 订单服务类
public class OrderService
{
    private List<Order> orders = new List<Order>(); // 存储订单列表

    // 添加订单
    public void AddOrder(Order order)
    {
        if (orders.Contains(order))
            throw new Exception("订单已存在！");
        orders.Add(order);
    }

    // 删除订单
    public void RemoveOrder(int orderId)
    {
        var order = orders.FirstOrDefault(o => o.OrderId == orderId); // 使用LINQ查找订单
        if (order == null)
            throw new Exception("订单不存在，无法删除！");
        orders.Remove(order);
    }

    // 更新订单
    public void UpdateOrder(Order updatedOrder)
    {
        var order = orders.FirstOrDefault(o => o.OrderId == updatedOrder.OrderId); // 使用LINQ查找订单
        if (order == null)
            throw new Exception("订单不存在，无法更新！");
        order.Customer = updatedOrder.Customer;
        order.Details = updatedOrder.Details;
    }

    // 查询订单（支持多种条件查询）
    public List<Order> QueryOrders(Func<Order, bool> predicate)
    {
        return orders.Where(predicate).OrderBy(o => o.TotalAmount).ToList(); // 使用LINQ进行筛选和排序
    }

    // 对订单进行排序，默认按照订单号排序，也支持自定义排序
    public void SortOrders(Comparison<Order> comparison = null)
    {
        orders.Sort(comparison ?? ((o1, o2) => o1.OrderId.CompareTo(o2.OrderId)));
    }
}

// 测试类
public class OrderServiceTest
{
    public static void RunTests()
    {
        var service = new OrderService();
        var customer = new Customer { Name = "张三" };
        var goods = new Goods { Name = "手机", Price = 5000 };
        var order1 = new Order { OrderId = 1, Customer = customer };
        order1.Details.Add(new OrderDetails { Product = goods, Quantity = 2 });

        // 测试添加订单
        service.AddOrder(order1);
        Console.WriteLine("添加订单成功！");

        // 测试查询订单
        var results = service.QueryOrders(o => o.Customer.Name == "张三"); // 使用LINQ进行查询
        Console.WriteLine("查询订单:");
        results.ForEach(Console.WriteLine);

        // 测试排序订单
        service.SortOrders();
        Console.WriteLine("订单排序后:");
        service.QueryOrders(o => true).ForEach(Console.WriteLine);

        // 测试删除订单
        service.RemoveOrder(1);
        Console.WriteLine("删除订单成功！");
    }
}

// 主程序
class Program
{
    static void Main()
    {
        OrderServiceTest.RunTests(); // 运行测试
    }
}
