
import { AllCommunityModule, ModuleRegistry } from 'ag-grid-community'; 
import Grid from "./Components/Grid";
import NavbarCustom from './Components/Navbar';

// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);

const App = () => {
  return (
    <div>
      <NavbarCustom />
      <Grid />
    </div>
  );
};

export default App;
