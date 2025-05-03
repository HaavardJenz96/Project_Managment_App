import { useState } from "react";
import GridCustomers from "../Components/Grid";
import NavbarCustom from "../Components/Navbar";

export default function Customers() {
    const [colDefs, setColDefs] = useState([
      { field: "name", type: 'name'},
      { field: "customerSince" },
      { field: "employees" },
      { field: "projects" },
    ]);
  
  return (
    <div>
      <NavbarCustom />
      <GridCustomers
      apiUrl={'https://localhost:7003/api/customers'}
      colDefs={colDefs}
      ></GridCustomers>
    
    </div>
  );
}