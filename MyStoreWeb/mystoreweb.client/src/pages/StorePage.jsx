import { useEffect, useState } from "react";

const thClass = "border-b py-2 px-4 text-left text-lg font-semibold";
const tdClass = "border-b py-2 px-4";

const StorePage = () => {
    const [products, setProducts] = useState(null);
    const [isLoading, setIsLoading] = useState(true);

    useEffect(() => {
        const fetchStoreData = async () => {
            setIsLoading(true);

            const response = await fetch('https://localhost:7077/api/products');

            const data = await response.json();

            setProducts(data);

            setIsLoading(false);
        };

        fetchStoreData();
    }, []);


    return (
        <div className="p-8">
            <h1 className="text-3xl font-bold">Store</h1>

            {!isLoading && products && (
                <div className="mt-6">
                    <table className="min-w-full border-collapse table-auto">
                        <thead>
                            <tr>
                                <th className={thClass}>Product Name</th>
                                <th className={thClass} >Product Price</th>
                            </tr>
                        </thead>
                        <tbody>
                            {products.map((product) => (
                                <tr key={product.id}>
                                    <td className={tdClass}>{product.name}</td>
                                    <td className={tdClass}>{product.cost.toFixed(2)}</td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                </div>
            )}
        </div>
    );
};

export default StorePage;