## Predictable

> Intention-revealing code uses clear and descriptive names to communicate the purpose of components. Here's an example of naming a function using intention-revealing names

```python
def calculate_total_price(item_prices):
    total = sum(item_prices)
    return total

prices = [10, 20, 30]
total_price = calculate_total_price(prices)
print(total_price)  # Output: 60

```