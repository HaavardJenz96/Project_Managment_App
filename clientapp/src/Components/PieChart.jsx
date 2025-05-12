import React, { useState, useEffect } from "react";
import Chart from "react-apexcharts";

const PieChart = () => {
  const [data, setData] = useState({ series: [], labels: [] });
  const [isReady, setIsReady] = useState(false);

  useEffect(() => {
    fetch("https://localhost:7003/api/ViewProjectStatus")
      .then((result) => result.json())
      .then((data) => {
        const series = data.map((x) => x.percentageComplete);
        const labels = data.map((x) => x.projectName);

        setData({ series, labels });

        // Set a short delay before showing the chart (e.g., 300ms)
        setTimeout(() => {
          setIsReady(true);
        }, 100);
      })
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  const options = {
    labels: data.labels,
    responsive: [
      {
        breakpoint: 480,
        options: {
          chart: {
            width: 200,
          },
          legend: {
            position: "bottom",
          },
        },
      },
    ],
  };

  return (
    <div className="app">
      <div className="row">
        <div className="mixed-chart">
          {isReady ? (
            <Chart
              options={options}
              series={data.series}
              type="pie"
              width="500"
            />
          ) : (
            <div>Loading chart...</div>
          )}
        </div>
      </div>
    </div>
  );
};

export default PieChart;
