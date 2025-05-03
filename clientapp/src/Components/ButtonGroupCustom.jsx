import { Button} from "react-bootstrap";

const ButtonGroupCustom = () => {



  return (
    <div className="d-flex justify-content-center">
      <Button variant="primary" type="Button" className="me-1">View</Button>
      <Button id="add-accMan-btn" variant="primary" type="Button" className="me-1">Add Account Manager</Button>
    </div>
  );
};

export default ButtonGroupCustom;
