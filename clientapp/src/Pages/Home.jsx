import NavbarCustom from "../Components/Navbar";
import React, { useState } from "react";
import { Card, Row, Col, Button, Container } from "react-bootstrap";
import GridCustomers from "../Components/Grid";
import ButtonGroupCustom from "../Components/ButtonGroupCustom";

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
      <h1 className="text-center mt-4">Home is where ./ is</h1>
        
      <ButtonGroupCustom  />
    </div>
  );
}
