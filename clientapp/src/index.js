import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import 'bootstrap/dist/css/bootstrap.min.css';
import {createBrowserRouter, RouterProvider} from 'react-router-dom'
import Home from './Pages/Home';
import Customers from './Pages/Customers';
import { AllCommunityModule, ModuleRegistry } from 'ag-grid-community'; 
import NotFound from './Pages/NotFound';
import AccountManagers from './Pages/AccountManagers';
// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);


const router = createBrowserRouter([
{
  path: '/',
  element: <Home />,
  errorElement: <NotFound></NotFound>
},

{
  path: '/Customers',
  element: <Customers />,
},
{
  path: '/AccountManagers',
  element: <AccountManagers/>
}
]);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <RouterProvider router={router}></RouterProvider>
  </React.StrictMode>
);


// Optional: Log results or send to analytics
reportWebVitals(console.log); // or replace with your own function