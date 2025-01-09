import { useNavigate } from 'react-router-dom';

const buttonClass = "bg-blue-500 text-white py-2 px-4 rounded mr-4 hover:bg-blue-400";

const HomePage = () => {
    const navigate = useNavigate();


    return (
        <div className="p-8 text-center">
            <h1 className="text-3xl font-bold">My Store</h1>

            <div className="mt-6">
                <button
                    onClick={() => navigate('/store')}
                    className={buttonClass}
                >
                    Store
                </button>
                <button
                    onClick={() => navigate('/orders')}
                    className={buttonClass}
                >
                    My Orders
                </button>
            </div>
        </div>
    );
};

export default HomePage;
