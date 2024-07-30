const unitPriceElement = document.querySelector('#Price');
const quantityElement = document.querySelector('#Quantity');
const orderTotalElement = document.querySelector('#order-total');
if (quantityElement && unitPriceElement && orderTotalElement) {
    quantityElement.addEventListener('change', _ => {
        const unitPrice = Number(unitPriceElement.value);
        const quantity = Number(quantityElement.value);
        const orderTotal = unitPrice * quantity;
        orderTotalElement.textContent = orderTotal.toLocaleString("en-IN", {
            style: 'currency',
            currency: 'INR'
        });
    });
}