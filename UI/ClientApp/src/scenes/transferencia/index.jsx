import { Box } from "@mui/material";
import { tokens } from "../../theme";
import Autocomplete from '@mui/material/Autocomplete';
import TextField from '@mui/material/TextField';
import Header from "../../components/Header";
import ArrowForwardIcon from '@mui/icons-material/ArrowForward';
import { useTheme } from "@mui/material";
import Button from '@mui/material/Button';
import AddIcon from '@mui/icons-material/Add';
import { styled } from '@mui/material/styles';
import * as React from 'react';
import SendIcon from '@mui/icons-material/Send';
import { DataGrid, GridColDef, GridValueGetterParams, GridActionsCellItem } from '@mui/x-data-grid';
import DeleteIcon from '@mui/icons-material/Delete';
import Stack from "@mui/material/Stack";


const Transferencia = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const top100Films = [
    { label: 'The Shawshank Redemption', year: 1994 },
    { label: 'The Godfather', year: 1972 },
    { label: 'The Godfather: Part II', year: 1974 },
    { label: 'The Dark Knight', year: 2008 },
    { label: '12 Angry Men', year: 1957 },
    { label: "Schindler's List", year: 1993 },
    { label: 'Pulp Fiction', year: 1994 },
    {
      label: 'The Lord of the Rings: The Return of the King',
      year: 2003,
    },
  ];
  const columns = [
    {
      field: 'producto',
      headerName: 'Producto',
      flex: 1,
      minWidth: 40,
      editable: true,
    },
    {
      field: 'cantidad',
      headerName: 'Cantidad',
      flex: 1,
      minWidth: 40,
      editable: true,
    },
    { field: "actions",
    headerName: "Accionces",
    type: "actions",
    minWidth: 40,
    flex: 1,
    getActions: (params) => [
    <GridActionsCellItem
            icon={<DeleteIcon />}
            label="Delete"
    />]
    }
  ];
  const rows = [
    { id: 1, producto: 'Snow', cantidad: 35 },
    { id: 2, producto: 'Lannister', cantidad: 42 },
    { id: 3, producto: 'Lannister', cantidad: 45 },
    { id: 4, producto: 'Stark', cantidad: 16 },
  ];
  return (
    <Box m="20px">
      <Header
        title="Transferencias"
        subtitle="Realizar transferencias"
      />
      <Stack direction="row" spacing={2} sx={{mb: 2}}>
        {/* ROW 1 */}
        <Autocomplete
        disablePortal
        id="combo-box-demo"
        options={top100Films}
        sx={{ width: 300 }}
        renderInput={(params) => <TextField {...params} label="Origen" />}
        />
        <ArrowForwardIcon sx={{ color: colors.greenAccent[600], fontSize: "46px" }}/>
        <Autocomplete
        disablePortal
        id="combo-box-demo"
        options={top100Films}
        sx={{ width: 300 }}
        renderInput={(params) => <TextField {...params} label="Destino" />}
        />
      </Stack>
      
      {/* ROW 2 */}
      <Stack direction="row" spacing={2} sx={{mb: 2}} justifyContent="space-between">
        <Autocomplete
        disablePortal
        id="combo-box-demo"
        options={top100Films}
        sx={{ width: 300 }}
        renderInput={(params) => <TextField {...params} label="Producto" />}
        />
        <Stack direction="row" spacing={2}>
        <TextField id="outlined-basic" label="Cantidad" variant="outlined" sx={{width: 150}} />
        <Button variant="outlined" endIcon={<AddIcon />} sx={{width: 135, height: 52}}>
          Agregar
        </Button>
        </Stack>
      </Stack>
      <Stack direction="row" spacing={2}>
      <DataGrid
          rows={rows}
          columns={columns}
          initialState={{
            pagination: {
              paginationModel: {
                pageSize: 5,
              },
            },
          }}
          pageSizeOptions={[5]}
          disableRowSelectionOnClick
        />
      <Button variant="outlined" endIcon={<SendIcon />} sx={{width: 'auto', height: 'auto'}}>
          Enviar
      </Button>
   </Stack>

    </Box>
    
  );
}
export default Transferencia;