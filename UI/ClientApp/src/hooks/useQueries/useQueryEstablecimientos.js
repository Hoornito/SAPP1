import { useQuery } from 'react-query';
import { coreRestClient } from '../../utilities/RestClient';

const getEstablecimientos = async () => {
  const response = await coreRestClient.get('/establecimiento/establecimientos');
  return response.data;
};

const useQueryEstablecimientos = () => {
  const {
    data,
    error,
    refetch,
    status,
  } = useQuery(['establecimientos'], () => getEstablecimientos(), {
    enabled: true,
    refetchOnWindowFocus: false,
  });

  return {
    data,
    error,
    refetch,
    status,
  };
};

export default useQueryEstablecimientos;