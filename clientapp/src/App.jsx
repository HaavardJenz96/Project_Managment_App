
import { AllCommunityModule, ModuleRegistry } from 'ag-grid-community'; 
import Grid from "./Components/Grid";

// Register all Community features
ModuleRegistry.registerModules([AllCommunityModule]);

const App = () => {
  return (
    <div>
      <Grid />
    </div>
  );
};

export default App;
