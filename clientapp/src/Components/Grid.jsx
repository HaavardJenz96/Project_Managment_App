import { AgGridReact } from "ag-grid-react"; // React Data Grid Component
import React, { useState, useEffect, useMemo } from "react";


import "./GridStyle.css";

const GridCustomers = ({apiUrl, colDefs}) => {
  useEffect(() => {
    fetch(apiUrl) // Fetch data from server
      .then((result) => result.json()) // Convert to JSON
      .then((rowData) => {
        console.log("Fetched data:", rowData); // 👈 Log the data
        setRowData(rowData); // Update state
      })
      .catch((error) => console.error("Error fetching data:", error));
  }, [apiUrl]); // 👈 Also add apiUrl as dependency

  // Row Data: The data to be displayed.
  const [rowData, setRowData] = useState([
    { make: "Tesla", model: "Model Y", price: 64950, electric: true },
    { make: "Ford", model: "F-Series", price: 33850, electric: false },
    { make: "Toyota", model: "Corolla", price: 29600, electric: false },
  ]);

  const columnTypes = useMemo(() => { 
    return {
          name: { 
              width: 150,
              cellStyle: { fontWeight: 'bold' },
          },
          shaded: {
              cellClass: 'shaded-class'
          }
      };
  }, []);
  

  // Column Definitions: Defines the columns to be displayed.

  return (
    // Data Grid will fill the size of the parent container

    <div className="container fluid">
      <div className="row d-flex justify-content-center align-items-center mt-5">
       
            <div className="gridContainer">
          <AgGridReact rowData={rowData} columnDefs={colDefs} columnTypes={columnTypes}
          style={{ width: '100%', height: '100%' }}
          domLayout='autoHeight'
          />
          </div>
     
      </div>
    </div>
  );
};

export default GridCustomers;
