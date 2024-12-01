import React from 'react';
import CustomSelect from '../../../styles/CustomSelect';

interface MouthingSelectProps {
  value: string;
  onChange: (value: string | null) => void;
}

const mouthingOptions = [
  { label: 'Describing', value: 'describing' },
  { label: 'Vocaling', value: 'vocaling' },
  { label: 'Wording', value: 'wording' },
];

const MouthingSelect: React.FC<MouthingSelectProps> = ({ value, onChange }) => {
  return (
    <CustomSelect
      options={mouthingOptions}
      placeholder="Select Mouthing"
      value={value}
      onChange={onChange}
    />
  );
};

export default MouthingSelect;
