import NavbarCustom from "../Components/Navbar";
import {Card, Row, Col,Button }from 'react-bootstrap' 
import GridCustomers from "../Components/GridCustomers";

export default function Home() {
  return (
    <div>
      <NavbarCustom></NavbarCustom>
      <h1 className="text-center">Home</h1>

      <Card border="light" className="shadow-sm">
      <Card.Header>
        <Row className="align-items-center">
          <Col>
            <h5>Account Managers</h5>
          </Col>
          <Col className="text-end">
            <Button variant="secondary" size="sm">See all</Button>
          </Col>
        </Row>
        <GridCustomers/>
      </Card.Header>
      </Card>
    </div>
  );
}
