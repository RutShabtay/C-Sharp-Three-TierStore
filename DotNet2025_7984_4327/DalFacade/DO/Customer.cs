﻿namespace DO;

public record Customer(int CustomerId,
    string CustomerName,
    string CustomerAddress,
    string CustomerPhone)
{

    public Customer() : this(0, null, null, null) { }

}
