import NavbarCustom from "../Components/Navbar";
import React, { useState } from "react";
import { Card, Row, Col, Button, Container } from "react-bootstrap";
import GridCustomers from "../Components/Grid";
import ButtonGroupCustom from "../Components/ButtonGroupCustom";

export default function AccountManagers() {
  const [colDefs, setColDefs] = useState([
    { field: "full_Name", type: 'name'},
    { field: "companyAssignedTo" },
    { field: "email" },
    { field: "birth_Date", filter: "agDateColumnFilter", },
  ]);

  return (
    <div>
      <NavbarCustom />
      <h1 className="text-center mt-4">Account Managers</h1>
      <Container fluid>
      <GridCustomers
        apiUrl={"https://localhost:7003/api/AccountManagers"}
        colDefs={colDefs}
      />
      </Container>
      <ButtonGroupCustom  />
    </div>
  );
}
