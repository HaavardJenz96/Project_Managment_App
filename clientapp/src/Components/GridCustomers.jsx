import { AgGridReact } from "ag-grid-react"; // React Data Grid Component
import React, { useState, useEffect } from "react";
import "./GridStyle.css";

const GridCustomers = () => {
  useEffect(() => {
    fetch("https://localhost:7003/api/customers") // Fetch data from server
      .then((result) => result.json()) // Convert to JSON
      .then((rowData) => setRowData(rowData)); // Update state of `rowData`
  }, []);

  // Row Data: The data to be displayed.
  const [rowData, setRowData] = useState([
    { make: "Tesla", model: "Model Y", price: 64950, electric: true },
    { make: "Ford", model: "F-Series", price: 33850, electric: false },
    { make: "Toyota", model: "Corolla", price: 29600, electric: false },
  ]);

  // Column Definitions: Defines the columns to be displayed.
  const [colDefs, setColDefs] = useState([{ field: "name" }]);

  return (
    // Data Grid will fill the size of the parent container

    <div className="container">
      <div className="row d-flex justify-content-center align-items-center mt-5">
        <div className="col-10">
            <div className="gridContainer">
          <AgGridReact rowData={rowData} columnDefs={colDefs} />
          </div>
        </div>
      </div>
    </div>
  );
};

export default GridCustomers;
