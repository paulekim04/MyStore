import { Link } from 'react-router-dom';

const linkClass = "text-white hover:text-gray-400";

const Navbar = () => {
    return (
        <nav className="bg-gray-800 p-4">
            <ul className="flex space-x-8">
                <li>
                    <Link to="/" className={linkClass}>
                        Home
                    </Link>
                </li>
                <li>
                    <Link to="/store" className={linkClass}>
                        Store
                    </Link>
                </li>
                <li>
                    <Link to="/orders" className={linkClass}>
                        My Orders
                    </Link>
                </li>
            </ul>
        </nav>
    );
};

export default Navbar;
