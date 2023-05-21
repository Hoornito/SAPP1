import { Box } from "@mui/material";
import { DataGrid, GridToolbar } from "@mui/x-data-grid";
import { tokens } from "../../theme";
import { mockDataContacts } from "../../data/mockData";
import Header from "../../components/Header";
import { useTheme } from "@mui/material";
import { Button } from "@mui/material";
import useQueryEstablecimientos from '../../hooks/useQueries/useQueryEstablecimientos'


const Establecimientos = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const query = useQueryEstablecimientos();

  const columns = [
    {
      field: "id",
      headerName: "ID",
      width: 10
    },
    { field: "nombre", headerName: "Nombre", width: 140 },
    { field: "provincia", headerName: "Provincia", width: 140 },
    {
      field: "localidad",
      headerName: "Localidad",
      width: 140
    },
    {
      field: "tipo",
      headerName: "Tipo",
      width: 140
    },
  ];
console.log(query)

  return (
    <Box m="20px">
      <Header
        title="Establecimientos"
        subtitle="Lista de establecimientos"
      />
      <div className="m-2" >
        <Button variant="outlined">
        Agregar Establecimiento
        </Button>
        </div>
      <Box
        m="20px 0 0 0"
        height="60vh"
        sx={{
          "& .MuiDataGrid-root": {
            border: "none",
          },
          "& .MuiDataGrid-cell": {
            borderBottom: "none",
          },
          "& .name-column--cell": {
            color: colors.greenAccent[300],
          },
          "& .MuiDataGrid-columnHeaders": {
            backgroundColor: colors.blueAccent[700],
            borderBottom: "none",
          },
          "& .MuiDataGrid-virtualScroller": {
            backgroundColor: colors.primary[400],
          },
          "& .MuiDataGrid-footerContainer": {
            borderTop: "none",
            backgroundColor: colors.blueAccent[700],
          },
          "& .MuiCheckbox-root": {
            color: `${colors.greenAccent[200]} !important`,
          },
          "& .MuiDataGrid-toolbarContainer .MuiButton-text": {
            color: `${colors.grey[100]} !important`,
          },
        }}
      >
        {query.status==='loading' && <div>Loading...</div>}
        {query.status==='success' &&(
          <DataGrid
          rows={query.data}
          columns={columns}
          components={{ Toolbar: GridToolbar }}
        />
        )}
      </Box>
    </Box>
  );
};

export default Establecimientos;