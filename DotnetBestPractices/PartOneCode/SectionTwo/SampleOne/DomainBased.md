## Domain-based

> Domain-based code uses a language and structure that align with the problem domain. Here's an example of defining classes and functions that match a hypothetical e-commerce domain

```python
class Product:
    def __init__(self, name, price):
        self.name = name
        self.price = price

class ShoppingCart:
    def __init__(self):
        self.items = []

    def add_item(self, product, quantity):
        self.items.append((product, quantity))

    def calculate_total(self):
        total = sum(product.price * quantity for product, quantity in self.items)
        return total

# Usage
product1 = Product("Widget", 10)
product2 = Product("Gadget", 20)

cart = ShoppingCart()
cart.add_item(product1, 3)
cart.add_item(product2, 2)

total_amount = cart.calculate_total()
print(f"Total: ${total_amount}")  # Output: Total: $70

```