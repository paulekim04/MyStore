import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Navbar from './components/Navbar'
import OrderPage from "./pages/OrderPage";
import StorePage from "./pages/StorePage";
import HomePage from './pages/HomePage';

const App = () => {
    return (
        <Router>
            <Navbar />
            <div className="container mx-auto p-4">
                <Routes>
                    <Route path="/" element={<HomePage />} />
                    <Route path="/store" element={<StorePage />} />
                    <Route path="/orders" element={<OrderPage />} />
                </Routes>
            </div>
        </Router>
    );
};

export default App;