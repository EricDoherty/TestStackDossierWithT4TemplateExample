
using System;
using CustomizedTestStackDossierExample;
using TestStack.Dossier;
using TestStack.Dossier.Lists;
using TestStack.Dossier.EquivalenceClasses;

public partial class OrderBuilder : TestDataBuilder<Order, OrderBuilder>
{
	public OrderBuilder()
	{
		PopulateDefaultValues();
	}

	public virtual OrderBuilder WithCustomer(Func<CustomerBuilder, CustomerBuilder> modifier = null)
	{
		return Set(x => x.Customer, GetChildBuilder<Customer, CustomerBuilder>(modifier));
	}

	public virtual OrderBuilder WithCustomerId(int customerId)
	{
		return Set(x => x.CustomerId, customerId);
	}

	public virtual OrderBuilder WithItems(int listSize, Func<ListBuilder<Item, ItemBuilder>, ItemBuilder> modifier = null)
	{		
		return Set(x => x.Items, GetListChildBuilder<Item, ItemBuilder, ListBuilder<Item, ItemBuilder>>(() => ItemBuilder.CreateListOfSize(listSize), modifier));
	}

}

public partial class ItemBuilder : TestDataBuilder<Item, ItemBuilder>
{
	public ItemBuilder()
	{
		WithBrandName(Any.StringOfLength(100));
		WithName(Any.StringOfLength(50));
		PopulateDefaultValues();
	}

	public virtual ItemBuilder WithBrandName(string brandName)
	{
		return Set(x => x.BrandName, brandName);
	}

	public virtual ItemBuilder WithCost(double cost)
	{
		return Set(x => x.Cost, cost);
	}

	public virtual ItemBuilder WithName(string name)
	{
		return Set(x => x.Name, name);
	}

	public virtual ItemBuilder WithOrder(Func<OrderBuilder, OrderBuilder> modifier = null)
	{
		return Set(x => x.Order, GetChildBuilder<Order, OrderBuilder>(modifier));
	}

	public virtual ItemBuilder WithOrderId(int orderId)
	{
		return Set(x => x.OrderId, orderId);
	}

}

public partial class CustomerBuilder : TestDataBuilder<Customer, CustomerBuilder>
{
	public CustomerBuilder()
	{
		WithFirstName(Any.StringOfLength(100));
		WithLastName(Any.StringOfLength(100));
		WithMiddleName(Any.StringOfLength(100));
		PopulateDefaultValues();
	}

	public virtual CustomerBuilder WithAddress(Func<AddressBuilder, AddressBuilder> modifier = null)
	{
		return Set(x => x.Address, GetChildBuilder<Address, AddressBuilder>(modifier));
	}

	public virtual CustomerBuilder WithAddressId(int addressId)
	{
		return Set(x => x.AddressId, addressId);
	}

	public virtual CustomerBuilder WithAge(int age)
	{
		return Set(x => x.Age, age);
	}

	public virtual CustomerBuilder WithFirstName(string firstName)
	{
		return Set(x => x.FirstName, firstName);
	}

	public virtual CustomerBuilder WithLastName(string lastName)
	{
		return Set(x => x.LastName, lastName);
	}

	public virtual CustomerBuilder WithMiddleName(string middleName)
	{
		return Set(x => x.MiddleName, middleName);
	}

	public virtual CustomerBuilder WithOrders(int listSize, Func<ListBuilder<Order, OrderBuilder>, OrderBuilder> modifier = null)
	{		
		return Set(x => x.Orders, GetListChildBuilder<Order, OrderBuilder, ListBuilder<Order, OrderBuilder>>(() => OrderBuilder.CreateListOfSize(listSize), modifier));
	}

}

public partial class AddressBuilder : TestDataBuilder<Address, AddressBuilder>
{
	public AddressBuilder()
	{
		WithAddressLineOne(Any.StringOfLength(100));
		WithAddressLineThree(Any.StringOfLength(100));
		WithAddressLineTwo(Any.StringOfLength(100));
		WithCity(Any.StringOfLength(50));
		WithStateCode(Any.StringOfLength(2));
		WithZipCode(Any.StringOfLength(9));
		PopulateDefaultValues();
	}

	public virtual AddressBuilder WithAddressLineOne(string addressLineOne)
	{
		return Set(x => x.AddressLineOne, addressLineOne);
	}

	public virtual AddressBuilder WithAddressLineThree(string addressLineThree)
	{
		return Set(x => x.AddressLineThree, addressLineThree);
	}

	public virtual AddressBuilder WithAddressLineTwo(string addressLineTwo)
	{
		return Set(x => x.AddressLineTwo, addressLineTwo);
	}

	public virtual AddressBuilder WithCity(string city)
	{
		return Set(x => x.City, city);
	}

	public virtual AddressBuilder WithCustomers(int listSize, Func<ListBuilder<Customer, CustomerBuilder>, CustomerBuilder> modifier = null)
	{		
		return Set(x => x.Customers, GetListChildBuilder<Customer, CustomerBuilder, ListBuilder<Customer, CustomerBuilder>>(() => CustomerBuilder.CreateListOfSize(listSize), modifier));
	}

	public virtual AddressBuilder WithStateCode(string stateCode)
	{
		return Set(x => x.StateCode, stateCode);
	}

	public virtual AddressBuilder WithZipCode(string zipCode)
	{
		return Set(x => x.ZipCode, zipCode);
	}

}


