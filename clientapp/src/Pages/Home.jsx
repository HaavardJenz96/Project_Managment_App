import NavbarCustom from "../Components/Navbar";
import React, { useState } from "react";
import { Card, Row, Col, Button, Container } from "react-bootstrap";
import GridCustomers from "../Components/Grid";
import ButtonGroupCustom from "../Components/ButtonGroupCustom";
import PieChart from "../Components/PieChart";


export default function Home() {
  const [colDefs, setColDefs] = useState([
    { field: "full_Name", type: 'name'},
    { field: "companyAssignedTo" },
    { field: "email" },
    { field: "birth_Date", filter: "agDateColumnFilter", },
  ]);

  return (
    <div>
      <NavbarCustom />
      <h1 className="text-center mt-4"> Key data</h1>
      
      <div className="project-chart m-4">
      <h4>Project Categories</h4>
      <PieChart/>
      </div>
      
    
    </div>
  );
}
