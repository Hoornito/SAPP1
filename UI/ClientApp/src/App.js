import { Routes, Route } from "react-router-dom";
import Dashboard from "./scenes/dashboard";
import Usuarios from "./scenes/team";
import Productos from "./scenes/productos";
import Establecimientos from "./scenes/establecimientos";
import Operaciones from "./scenes/operaciones";
import Transferencia from "./scenes/transferencia";
import MiniDrawer from "./scenes/global/layout";
import { CssBaseline, ThemeProvider } from "@mui/material";
import { ColorModeContext, useMode } from "./theme";
import { QueryClient, QueryClientProvider } from 'react-query';

const queryClient = new QueryClient();


function App() {
  const [theme, colorMode] = useMode();

  return (
    
      <ColorModeContext.Provider value={colorMode}>
        <ThemeProvider theme={theme}>
          <CssBaseline />
          <div className="app">
          <QueryClientProvider client={queryClient}>
            <MiniDrawer>
            <main className="content">         
              <Routes>
                <Route path="/" element={<Dashboard />} />
                <Route path="/users" element={<Usuarios />} />
                <Route path="/establecimientos" element={<Establecimientos />} />
                <Route path="/productos" element={<Productos />} />
                <Route path="/transferencias" element={<Transferencia />} />
                <Route path="/operaciones" element={<Operaciones />} />
              </Routes>
            </main>
            </MiniDrawer>
          </QueryClientProvider>
          </div>
        </ThemeProvider>
      </ColorModeContext.Provider>
    
  );
}

export default App;