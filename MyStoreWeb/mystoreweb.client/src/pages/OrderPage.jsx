import { useEffect, useState } from "react";

const thClass = "border-b py-2 px-4 text-left text-lg font-semibold";
const tdClass = "border-b py-2 px-4";

const OrderPage = () => {
    const [orderData, setOrderData] = useState(null);
    const [isLoading, setIsLoading] = useState(true);

    useEffect(() => {
        const fetchOrderData = async () => {
            setIsLoading(true);

            const response = await fetch('https://localhost:7077/api/orders');
            const data = await response.json();

            setOrderData(data);
            setIsLoading(false);
        };

        fetchOrderData(); 
    }, []);

    return (
        <div className="p-8">
            <h1 className="text-3xl font-bold">My Orders</h1>
            {!isLoading && orderData && (
                <div className="mt-6">
                    <table className="min-w-full border-collapse table-auto">
                        <thead>
                            <tr>
                                <th className={thClass}>Order ID</th>
                                <th className={ thClass}>Net Price </th>
                            </tr>
                        </thead>
                        <tbody>
                            {orderData.map((order) => {
                                const totalNetPrice = order.items.reduce((acc, item) => acc + (item.netCost - item.accountDiscount - item.couponDiscount), 0);

                                return (
                                    <tr key={order.id}>
                                        <td className={tdClass}>{order.id}</td>
                                        <td className={tdClass}>{totalNetPrice.toFixed(2)}</td>
                                    </tr>
                                );
                            })}
                        </tbody>
                    </table>
                </div>
            )}
        </div>
    );
};

export default OrderPage;