import React, { useEffect, useState } from 'react';
import { Navbar } from 'react-bootstrap';

const Customers = () => {
  const [projects, setProjects] = useState([]);

  useEffect(() => {
    fetch('/api/customers')  // relative to the ASP.NET Core server
      .then(res => res.json())
      .then(data =>  {
        setProjects(data);
        console.log('data', data);
  })
      
      .catch(err => console.error('Error:', err));
  }, []);

  return (
    <div>
      <h2>Projects</h2>
      <Navbar/>
      <ul>
        {projects.map(project => (
          <li key={project.id}>{project.name} - {project.name}</li>
        ))}
      </ul>
    </div>
  );
};

export default Customers;
