import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";

const PieChart = () => {

const [series, setSeries] = useState([]);
const [SeriesPercentage, setSeriesPercentage] = useState([]);
const [labels, setLabels] = useState([]); 

const [chartData, setChartData] = useState({
          
    series: SeriesPercentage,
    options: {
      chart: {
        width: 380,
        type: 'pie',
      },
      label: labels,
      responsive: [{
        breakpoint: 480,
        options: {
          chart: {
            width: 200
          },
          legend: {
            position: 'bottom'
          }
        }
      }]
    },
  
  
});

  useEffect(() => {
    fetch("https://localhost:7003/api/ViewProjectStatus") 
      .then((result) => result.json()) 
      .then((data) => {
        setSeries(data); 
        setSeriesPercentage(data.map((x) => x.percentageComplete));
        setLabels(data.map((x) => x.projectName));

        setChartData({
            series: SeriesPercentage,
            label: labels
        });

      })
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  console.log("Labels: ", labels);
  console.log("series Perc: " , SeriesPercentage);
  console.log("chartData", chartData);

  return (
    <div className="app">
      <div className="row">
        <div className="mixed-chart">
          <Chart
            options={chartData.options}
            series={chartData.series}
            labels={chartData.labels}
            type="pie"
            width="300"
          />
        </div>
      </div>
    </div>
  );
};


export default PieChart;
