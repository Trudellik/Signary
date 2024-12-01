import React from 'react';
import HandshapeIcon from './IconInfo/HandshapeIcon';
import HandsUsageIcon from './IconInfo/HandsUsageIcon';
import ArticleCountIcon from './IconInfo/ArticleCountIcon';

import './EntrySign.css';
import { LingusticDefinition } from '../../models/SignModel';

interface EntryDescriptionProps {
  lingusticData: LingusticDefinition;
  articlesCount: number;
}

const EntryDescription = ({
  lingusticData,
  articlesCount,
}: EntryDescriptionProps) => {
  return (
    <div className="description" style={{ backgroundColor: 'red' }}>
      <HandshapeIcon handshape={lingusticData.handshape} />
      <HandsUsageIcon handsUsage={lingusticData.handsusage} />
      <ArticleCountIcon count={articlesCount} />
    </div>
  );
};

export default EntryDescription;
